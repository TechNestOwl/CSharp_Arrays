/*********************************************************

   Gill Guimaraes

   Lab #8

   I wrote this code myself...
   I did not use AI or copy code from Google or another student

 *********************************************************/

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void problem1Btn_Click(object sender, EventArgs e)
        {
            //initializng my empty array of 100 integers
            int[] zerosArray = new int[100];

            //looping through and setting each i to 0
            for (int i = 0;i < zerosArray.Length; i++)
            {
                zerosArray[i] = 0;
                //Console.WriteLine(zerosArray[i]);
                System.Diagnostics.Debug.WriteLine(zerosArray[i]); //outputing to debugging console

            }
        }

        private void problem2Btn_Click(object sender, EventArgs e)
        {

            int[] problem2Array = new int[100];

            for (int i = 0; i < problem2Array.Length; i++) 
            {
                problem2Array[i] = 500 + i;
                //Console.WriteLine(problem2Array[i]);
                System.Diagnostics.Debug.WriteLine(problem2Array[i]); //outputing to debugging console
            }

        }

        private void problem3Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
