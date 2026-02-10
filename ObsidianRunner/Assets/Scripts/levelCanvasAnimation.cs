using UnityEngine;

public class levelCanvasAnimation : MonoBehaviour
{
    public RectTransform labelButton;
    public RectTransform button1;
    public RectTransform button2;

    [SerializeField] float time = 1.5f;
    [SerializeField] Vector2 targetPos;
    [SerializeField] Vector2 targetPosb1;
    [SerializeField] Vector2 targetPosb2;

    public int TotalLevels;

    private void Start()
    {
        LevelData.Instance.TotalLevels = TotalLevels;
    }

    void OnEnable()
    {
        moveLable(labelButton);
        moveButon1(button1);
        moveButon2(button2);
    }

    public void moveLable(RectTransform l1) {
        LeanTween.move(l1, targetPos, time)
                 .setEaseOutBack();
    }

    public void moveButon1(RectTransform b1)
    {
        LeanTween.move(b1, targetPosb1, time)
                 .setEaseOutBack();
    }

    public void moveButon2(RectTransform b2)
    {
        LeanTween.move(b2, targetPosb2, time)
                 .setEaseOutBack();
    }
}
