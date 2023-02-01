using UnityEngine;
using System;
using System.Collections.Generic;
using static Models;


public class PlayerController : MonoBehaviour, IHitResponder
{
    Rigidbody characterRigidBody;
    Animator characterAnimator;
    PlayerInputActions playerInputActions;
    [HideInInspector]
    public Vector2 inputMovement;
    [HideInInspector]
    public Vector2 inputView;

    Vector3 playerMovement;

    [Header("Settings")]
    public PlayerSettingsModel settings;
    public bool isTargetMode;

    [Header("Camera")]
    public Transform cameraTarget;
    public CameraController cameraController;

    [Header("Movement")]    
    public float movementSpeedOffset = 1;
    public float movementSmoothDamp = 0.4f;
    public bool isWalking;
    [HideInInspector]
    public bool isSprinting;

    private float verticalSpeed;
    private float targetVerticalSpeed;
    private float verticalSpeedVelocity;

    private float horizontalSpeed; 
    private float targetHorizontalSpeed;
    private float horizontalSpeedVelocity;

    private Vector3 relativePlayerVelocity;

    [Header("Stats")]
    public PlayerStatsModel playerStats;

    [Header("Gravity")]
    public float gravity = 10f;
    public LayerMask groundMask;
    private Vector3 gravityDirection;

    [Header("Jumping / Falling")]
    private float fallingSpeed;
    private float fallingSpeedPeak;
    public float fallingThreshold;
    public float fallingMovementSpeed;
    public float fallingRunningMovementSpeed;
    private bool JumpingTriggered;
    public bool fallingTriggered;
    public float maxFallingMovementSpeed = 5;

    private Vector3 cameraRelativeForward;
    private Vector3 cameraRelativeRight;

    [Header("Combat")]
    public bool isFaceTarget;
    public Transform target;
    [HideInInspector]
    public bool isAttacking;
    public float stickyTargetDistance = 1f;
    public float stickyTargetAmount = 1f;
    public float combatCooldown = 2f;
    public float currentCombatCooldown;

    [SerializeField] private int _damage = 10;
    [SerializeField] private Hitbox _hitboxLightsaber;
    [SerializeField] private Hitbox _hitboxFoot;

    private List<GameObject> _objectsHit = new List<GameObject>();
    int IHitResponder.Damage { get => _damage; }

    private float fire1Timer;

    private void Start()
    {
        _hitboxLightsaber.HitResponder = this;
        _hitboxFoot.HitResponder = this;
    }
    #region - Awake -

    private void Awake()
    {
        characterRigidBody = GetComponent<Rigidbody>();
        characterAnimator = GetComponent<Animator>();

        playerInputActions = new PlayerInputActions();

        playerInputActions.Movement.Movement.performed += x => inputMovement = x.ReadValue<Vector2>();
        playerInputActions.Movement.View.performed += x => inputView = x.ReadValue<Vector2>();

        playerInputActions.Actions.Jump.performed += x => Jump();

        playerInputActions.Actions.WalkingToggle.performed += x => ToggleWalking();
        playerInputActions.Actions.Sprint.performed += x => Sprint();

        playerInputActions.Actions.Fire1.performed += x => Fire1();
        playerInputActions.Actions.Fire1Hold.performed += x => Fire1Hold();

        playerInputActions.Actions.Block.performed += x => Block();
        playerInputActions.Actions.BlockReleased.performed += x => BlockReleased();


        gravityDirection = Vector3.down;
    }

    #endregion

    #region - Jumping -

    private void Jump()
    {
        if (JumpingTriggered)
        {
            return;
        }

        JumpingTriggered = true;

        if (IsMoving() && IsInputMoving() && !isWalking)
        {
            characterAnimator.SetTrigger("RunningJump");
        }
        else if (IsMoving() && IsInputMoving() && isWalking)
        {
            characterAnimator.SetTrigger("WalkingJump");
        }
        else
        {
            characterAnimator.SetTrigger("Jump");
        }
    }

    public void ApplyJumpForce()
    {
        if (!IsGrounded())
        {
            return;
        }

        characterRigidBody.AddForce(transform.up * settings.JumpingForce, ForceMode.Impulse);
        fallingTriggered = true;
    }

    #endregion

    #region - Sprinting -

    private void Sprint()
    {
        if (!CanSprint())
        {
            return;
        }

        if (playerStats.Stamina > (playerStats.MaxStamina / 4))
        {
            isSprinting = true;
        }
    }

    private bool CanSprint()
    {
        if (isTargetMode)
        {
            return false;
        }

        var sprintFalloff = 0.8f;

        if ((inputMovement.y < 0 ? inputMovement.y * -1 : inputMovement.y) < sprintFalloff && (inputMovement.x < 0 ? inputMovement.x * -1 : inputMovement.x) < sprintFalloff)
        {
            return false;
        }

        return true;
    }

    private void CalculateSprint()
    {
        if (!CanSprint())
        {
            isSprinting = false;
        }

        if (isSprinting)
        {
            if (playerStats.Stamina > 0)
            {
                playerStats.Stamina -= playerStats.StaminaDrain * Time.deltaTime;
            }
            else
            {
                isSprinting = false;
            }

            playerStats.StaminaCurrentDelay = playerStats.StaminaDelay;
        }
        else
        {
            if (playerStats.StaminaCurrentDelay <= 0)
            {
                if (playerStats.Stamina < playerStats.MaxStamina)
                {
                    playerStats.Stamina += playerStats.StaminaRestore * Time.deltaTime;
                }
                else
                {
                    playerStats.Stamina = playerStats.MaxStamina;
                }
            }
            else
            {
                playerStats.StaminaCurrentDelay -= Time.deltaTime;
            }
        }
    }

    #endregion

    #region - Gravity -

    private bool IsGrounded()
    {
        if (Physics.CheckSphere(transform.position, 0.4f, groundMask))
        {
            return true;
        }

        return false;
    }

    private bool IsFalling()
    {
        if (fallingSpeed < fallingThreshold)
        {
            return true;
        }

        return false;
    }

    private void CalculateGravity()
    {
        Physics.gravity = gravityDirection * gravity;
    }

    private void CalculateFalling()
    {
        fallingSpeed = relativePlayerVelocity.y;

        if (fallingSpeed < fallingSpeedPeak && fallingSpeed < -0.1f && (fallingTriggered || JumpingTriggered))
        {
            fallingSpeedPeak = fallingSpeed;
        }

        if ((IsFalling() && !IsGrounded() && !JumpingTriggered && !fallingTriggered) || (JumpingTriggered && !fallingTriggered && !IsGrounded()))
        {
            fallingTriggered = true;
            characterAnimator.SetTrigger("Falling");
        }

        if (fallingTriggered && IsGrounded() && fallingSpeed < -0.1f)
        {
            fallingTriggered = false;
            JumpingTriggered = false;

            if (fallingSpeedPeak < -12)
            {
                characterAnimator.SetTrigger("HardLand");
            }
            else
            {
                characterAnimator.SetTrigger("Land");
            }

            fallingSpeedPeak = 0;
        }
    }

    #endregion

    #region - Movement -

    private void ToggleWalking()
    {
        isWalking = !isWalking;
    }

    public bool IsMoving()
    {
        if (relativePlayerVelocity.x > 0.4f || relativePlayerVelocity.x < -0.4f)
        {
            return true;
        }

        if (relativePlayerVelocity.z > 0.4f || relativePlayerVelocity.z < -0.4f)
        {
            return true;
        }

        return false;
    }

    public bool IsInputMoving()
    {
        if (inputMovement.x > 0.1f || inputMovement.x < -0.1f)
        {
            return true;
        }

        if (inputMovement.y > 0.1f || inputMovement.y < -0.1f)
        {
            return true;
        }

        return false;
    }

    private void Movement()
    {
        characterAnimator.SetBool("IsTargetMode", isTargetMode);

        relativePlayerVelocity = transform.InverseTransformDirection(characterRigidBody.velocity);

        if (isTargetMode)
        {
            if (inputMovement.y > 0)
            {
                targetVerticalSpeed = (isWalking ? settings.WalkingSpeed : settings.RunningSpeed);
            }
            else
            {
                targetVerticalSpeed = (isWalking ? settings.WalkingBackwardSpeed : settings.RunningBackwardSpeed);
            }

            targetHorizontalSpeed = (isWalking ? settings.WalkingStrafingSpeed : settings.RunningStrafingSpeed);

            if (isFaceTarget && target)
            {
                var lookDirection = target.position - transform.position;
                lookDirection.y = 0;

                var currentRotation = transform.rotation;

                transform.LookAt(lookDirection + transform.position, Vector3.up);
                var newRotation = transform.rotation;

                transform.rotation = Quaternion.Lerp(currentRotation, newRotation, settings.CharacterRotationSmoothDamp);
            }
            else
            {
                var currentRotation = transform.rotation;

                var newRotation = currentRotation.eulerAngles;
                newRotation.y = cameraController.targetRotation.y;

                currentRotation = Quaternion.Lerp(currentRotation, Quaternion.Euler(newRotation), settings.CharacterRotationSmoothDamp);

                transform.rotation = currentRotation;
            }
        }
        else
        {
            var orginalRotation = transform.rotation;
            transform.LookAt(playerMovement + transform.position, Vector3.up);
            var newRotation = transform.rotation;

            transform.rotation = Quaternion.Lerp(orginalRotation, newRotation, settings.CharacterRotationSmoothDamp);

            float playerSpeed = 0;

            if (isSprinting)
            {
                playerSpeed = settings.SprintingSpeed;
            }
            else
            {
                playerSpeed = (isWalking ? settings.WalkingSpeed : settings.RunningSpeed);
            }

            targetVerticalSpeed = playerSpeed;
            targetHorizontalSpeed = playerSpeed;
        }

        targetVerticalSpeed = (targetVerticalSpeed * movementSpeedOffset) * inputMovement.y;
        targetHorizontalSpeed = (targetHorizontalSpeed * movementSpeedOffset) * inputMovement.x;

        verticalSpeed = Mathf.SmoothDamp(verticalSpeed, targetVerticalSpeed, ref verticalSpeedVelocity, movementSmoothDamp);
        horizontalSpeed = Mathf.SmoothDamp(horizontalSpeed, targetHorizontalSpeed, ref horizontalSpeedVelocity, movementSmoothDamp);

        if (isTargetMode)
        {
            var relativeMovement = transform.InverseTransformDirection(playerMovement);

            characterAnimator.SetFloat("Vertical", relativeMovement.z);
            characterAnimator.SetFloat("Horizontal", relativeMovement.x);
        }
        else
        {
            float verticalActualSpeed = verticalSpeed < 0 ? verticalSpeed * -1 : verticalSpeed;
            float horizontalActualSpeed = horizontalSpeed < 0 ? horizontalSpeed * -1 : horizontalSpeed;

            float animatorVertical = verticalActualSpeed > horizontalActualSpeed ? verticalActualSpeed : horizontalActualSpeed;

            characterAnimator.SetFloat("Vertical", animatorVertical);
        }

        if (IsInputMoving())
        {
            cameraRelativeForward = cameraController.transform.forward;
            cameraRelativeRight = cameraController.transform.right;
        }

        playerMovement = cameraRelativeForward * verticalSpeed;
        playerMovement += cameraRelativeRight * horizontalSpeed;

        if (JumpingTriggered || IsFalling())
        {
            characterAnimator.applyRootMotion = false;

            if(Vector3.Dot(characterRigidBody.velocity, playerMovement) < maxFallingMovementSpeed)
            {
                characterRigidBody.AddForce(playerMovement * (isWalking ? fallingMovementSpeed : fallingRunningMovementSpeed));
            }
        }
        else
        {
            characterAnimator.applyRootMotion = true;
        }

        if(isAttacking && IsGrounded() && isTargetMode)
        {
            isFaceTarget = true;

            if(Vector3.Distance(transform.position, target.transform.position) > stickyTargetDistance)
            {
                characterRigidBody.AddRelativeForce(Vector3.forward * stickyTargetAmount, ForceMode.Force);
            }
        }
    }

    #endregion

    #region - Combat -

    public void Fire1()
    {
        if(!isAttacking && IsGrounded() && !JumpingTriggered)
        {
            if (fire1Timer <= 0)
            {
                fire1Timer = 0.4f;
                return;
            }

            StartAttacking();
            characterAnimator.SetTrigger("MeleeAttack1");
            _hitboxLightsaber.CheckHit();

        }
    }

    public void Fire1Hold()
    {
        if (IsGrounded() && !JumpingTriggered)
        {
            StartAttacking();
            characterAnimator.SetTrigger("MeleeAttack2");
            _hitboxFoot.CheckHit();
        }
    }

    public void Block()
    {
        if (!isAttacking && IsGrounded() && !JumpingTriggered)
        {
            StartAttacking();
            characterAnimator.SetBool("Blocking", true);
        }
    }
    public void BlockReleased()
    {
        if (isAttacking && IsGrounded() && !JumpingTriggered)
        {
            FinishedAttacking();
            characterAnimator.SetBool("Blocking", false);
        }
    }

    public void CalculateCombat()
    {
        if(fire1Timer >= 0)
        {
            fire1Timer -= Time.deltaTime;
        }

        if(currentCombatCooldown > 0)
        {
            if(!isAttacking)
            {
                currentCombatCooldown -= Time.deltaTime;
            }
        }
        else
        {
            isTargetMode = false;
        }

        if(IsFalling())
        {
            isTargetMode = false;
            isAttacking = false;
        }
    }

    #endregion

    #region - Events -

    public void StartAttacking()
    {
        isAttacking = true;
        isTargetMode = true;
    }

    public void FinishedAttacking()
    {
        _objectsHit.Clear();
        currentCombatCooldown = combatCooldown;
        isAttacking = false;
    }

    #endregion

    #region - Update -

    private void Update()
    {
        CalculateGravity();
        CalculateFalling();
        Movement();
        CalculateSprint();

        CalculateCombat();
    }

    #endregion

    #region - Hitbox / Hurtbox -

    bool IHitResponder.CheckHit(HitData data)
    {
        if(data.hurtbox.Owner == gameObject) { return false; }
        else if(_objectsHit.Contains(data.hurtbox.Owner)) { return false; }
        else { return true; }
    }

    void IHitResponder.Response(HitData data)
    {
        _objectsHit.Add(data.hurtbox.Owner);
    }

    #endregion

    #region - Enable/Disable -

    private void OnEnable()
    {
        playerInputActions.Enable();
    }

    private void OnDisable()
    {
        playerInputActions.Disable();
    }

    #endregion

    #region - Gizmos -

    private void OnDrawGizmosSelected()
    {
        //Gizmos.color = Color.red;
        //Gizmos.DrawSphere(transform.position, 0.2f);
    }

    #endregion
}