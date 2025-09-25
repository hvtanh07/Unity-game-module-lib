using UnityEngine;
using UnityEngine.UIElements;

public class HealthPresenter : MonoBehaviour
{
    [SerializeField] private UIDocument m_Document;
    [SerializeField] private HealthModel m_HealthModelAsset;
    private VisualElement m_Root;
    private ProgressBar m_HealthBar;
    private Label m_StatusLabel;
    private Label m_ValueLabel;
    private void OnEnable()
    {
        m_Root = m_Document.rootVisualElement;

        if (m_HealthModelAsset != null)
        {
            m_HealthModelAsset.HealthChanged += OnHealthChanged;
            UpdateUI();
        }
    }
    private void OnHealthChanged() => UpdateUI();
    private void OnDisable()
    {
        if (m_HealthModelAsset != null)
            m_HealthModelAsset.HealthChanged -= OnHealthChanged;
    }
    private void UpdateUI()
    {

        // Logic to update UI elements based on the health model data
    }
    private void RegisterElements()
    {
        var resetButton = m_Root.Q<Button>("reset - button");
        if (resetButton != null)
            resetButton.clicked += RestoreHealth;
    }
    public void RestoreHealth() => m_HealthModelAsset.Restore();
    public void ApplyDamage(int damage) => m_HealthModelAsset
    .Decrement(damage);
}
