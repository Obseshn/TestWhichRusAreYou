using UnityEngine;

public class QuestionsAnalyzer : MonoBehaviour
{
    [SerializeField] private Version[] versions;
    private readonly int range = 3;
    public void AddNewRequest(QuentionWithAnswers request)
    {
        foreach (Version item in versions)
        {
            if (item.GetID() >= request.GetAnswerIndex() - range || item.GetID() <= request.GetAnswerIndex() + range)
            {
                item.AddPoint();
            } 
        }
    }
}
