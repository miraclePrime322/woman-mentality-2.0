using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Player player;
    private Player Player;
    private Animator animator;
    private const string RUNNING = "running";

    private void Awake()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("runing",false);
    }

    private void Update()
    {
        animator.SetBool(RUNNING , player.runing());
    }
}
