using UnityEngine.UI;
using UnityEngine;

public class QuestionsController : MonoBehaviour
{
    [SerializeField] private Text questText;
    [SerializeField] private QuentionWithAnswers[] questAndAnswer;
    [SerializeField] private Text[] answersTexts;
    [SerializeField] private QuestionsAnalyzer analyzer;
    private int countOfQue;
    private QuentionWithAnswers currentCAA;
    private int lastQuestionIndex;
    private void Start()
    {
        MixArray(questAndAnswer);
        lastQuestionIndex = 0;
        countOfQue = questAndAnswer.Length;
        ChangeQuestion();
    }

    public void MixArray(QuentionWithAnswers[] array)
    {
        for (int i = array.Length - 1; i >= 1; i--)
        {
            int j = Random.Range(0, array.Length);
            // обменять значения data[j] и data[i]
            var temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
    public void Answer(int index)
    {
        analyzer.AddNewRequest(currentCAA);
        ChangeQuestion();
    }

    public void ChangeQuestion()
    {
        if (lastQuestionIndex >= countOfQue)
        {
            return;
        }

        string[] answers = questAndAnswer[lastQuestionIndex].GetAnswers();
        questText.text = questAndAnswer[lastQuestionIndex].GetQuention();

        currentCAA = questAndAnswer[lastQuestionIndex];

        for (int i = 0; i < answers.Length; i++)
        {
            answersTexts[i].text = answers[i]; 
        }
        lastQuestionIndex++;
    }

    private bool IsArrayContainsInt(int value, int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (value == array[i])
            {
                return true;
            }
        }
        return false;
    }


}
