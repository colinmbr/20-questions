using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Questions
{
    class ActualQuestions
    {

        private Questions[,] tree = new Questions[5, 4];
        private Questions[,] treeI = new Questions[8,4];

        public ActualQuestions()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    tree[i,j] = new Questions();
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    treeI[i,j] = new Questions();
                }
            }
        }

        public void fill()
        {
            tree[0,0].setQuestion("Does it fly?");
            tree[0,1].setQuestion("Does it have feathers?");
            tree[0,2].setQuestion("Is it big?");
            tree[1,1].setQuestion("Is it mythical?");
            tree[2,0].setQuestion("Does it usually weigh more than 100 pounds?");
            tree[2,1].setQuestion("Is it aggressive?");
            //tree[2,2].setQuestion("Does it live in the jungle?");
            //tree[3,1].setQuestion("Does it have antlers?");
            tree[3,0].setQuestion("Does it have big ears?");
        }
        public void fillI()
        {
            treeI[0,0].setQuestion("Does it have strings?");
            treeI[0,1].setQuestion("Is it usually played with a pick/bow?");
            treeI[0,2].setQuestion("Is it bigger than a mandolin?");
            treeI[0,3].setQuestion("Does it have more than 5 strings?");
            treeI[3,0].setQuestion("Would you hear it in an orchestra?");
            treeI[1,0].setQuestion("Do you hold it while playing?");
            treeI[1,1].setQuestion("Does it have frets?");
            treeI[2,0].setQuestion("Does it have keys?");
            treeI[4,0].setQuestion("Is it big?");
            treeI[4,1].setQuestion("Is it a brass instrument?");
            treeI[4,2].setQuestion("Does it slide?");
            treeI[5,0].setQuestion("Would you hear it in a rock band?");
            treeI[6,0].setQuestion("Do you blow into it?");
            treeI[6,1].setQuestion("Is it longer than 1 foot?");
            treeI[7,0].setQuestion("Is it a geometric shape?");
        }
        public String getQuestion(int i, int j)
        {
            return tree[i,j].getQuestion();
        }
        public String getQuestionI(int i, int j)
        {
            return treeI[i,j].getQuestion();
        }
        public String getAnswer(int i, int j)
        {
            return tree[i,j].getAnswer();
        }
        public String getAnswerI(int i, int j)
        {
            return treeI[i,j].getAnswer();
        }
        public void setAnswer(int i, int j, String answer)
        {
            tree[i,j].setAnswer(answer);
        }
        public void setAnswerI(int i, int j, String answer)
        {
            treeI[i,j].setAnswer(answer);
        }

    }
}
