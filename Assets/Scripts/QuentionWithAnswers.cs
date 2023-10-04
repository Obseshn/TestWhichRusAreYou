using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Q&A", menuName = "Q&A")]
public class QuentionWithAnswers : ScriptableObject
{
    [SerializeField] private string question;
    [SerializeField] private string[] answers;
    private int answerIndex;

    public void SetAnswerIndex(int index = 0)
    {
        answerIndex = index;
    }

    public int GetAnswerIndex()
    {
        return answerIndex;
    }

    public string GetQuention()
    {
        return question;
    }

    public string[] GetAnswers()
    {
        return answers;
    }
}
