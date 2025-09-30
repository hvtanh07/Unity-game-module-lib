using UnityEngine;

[RequireComponent(typeof(Animator))]
public class FootIK : MonoBehaviour
{
    private Animator animator;

    [Range(0, 1)]
    [SerializeField] private float rightFootIKWeight = 1;
    [Range(0, 1)]
    [SerializeField] private float leftFootIKWeight = 1;

    [SerializeField] private float raycastDistance = 1.0f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float footOffset = 0.1f; // To lift the foot slightly off the ground

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // This callback is called by Unity after the animation has been processed
    private void OnAnimatorIK(int layerIndex)
    {
        if (animator == null) return;

        // Set the weight for each foot's IK
        animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, rightFootIKWeight);
        animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, rightFootIKWeight);
        animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, leftFootIKWeight);
        animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, leftFootIKWeight);

        // Process Right Foot
        ProcessFootIK(AvatarIKGoal.RightFoot, rightFootIKWeight);

        // Process Left Foot
        ProcessFootIK(AvatarIKGoal.LeftFoot, leftFootIKWeight);
    }

    private void ProcessFootIK(AvatarIKGoal foot, float weight)
    {
        if (weight == 0) return;

        // 1. Get original foot position from the animation
        Vector3 footPosition = animator.GetIKPosition(foot);

        // 2. Raycast down to find the ground
        RaycastHit hit;
        Ray ray = new Ray(footPosition + Vector3.up * 0.5f, Vector3.down); // Start ray slightly above the foot

        if (Physics.Raycast(ray, out hit, raycastDistance + 0.5f, groundLayer))
        {
            // 3. Calculate new position and rotation for the foot
            Vector3 targetPosition = hit.point + new Vector3(0, footOffset, 0);
            Quaternion targetRotation = Quaternion.FromToRotation(Vector3.up, hit.normal) * animator.GetIKRotation(foot);

            // 4. Set the IK goal for the foot
            animator.SetIKPosition(foot, targetPosition);
            animator.SetIKRotation(foot, targetRotation);
        }
    }
}
