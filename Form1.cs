/*********************************************************

   Gill Guimaraes

   Lab #9

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
            try
            {
                //looping through and intentionally Indexing out of bounds
                for (int i = 0; i < zerosArray.Length + 1; i++)
                {
                    zerosArray[i] = 0;
                    //Console.WriteLine(zerosArray[i]);

                    System.Diagnostics.Debug.WriteLine(zerosArray[i]);

                }
            }
            catch(Exception ex) //handling the error by displaying message box.
            {
                MessageBox.Show(ex.Message);
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
            double[] FahrTemps = new double[16];
            double[] CelTemps = new double[16];

            for (int i = 0; i < FahrTemps.Length; i++)
            {
                FahrTemps[i] = i * 20; // Fahrenheit: 0, 20, 40,..300
                CelTemps[i] = (FahrTemps[i] - 32) * 5 / 9; // Converting Fhrenheit to Celsius
            }
            System.Diagnostics.Debug.WriteLine("Fahreheit\tCelsius");
            for (int i = 0; i < FahrTemps.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine($"{FahrTemps[i],5}\t{CelTemps[i]:F2}");
            }



        }
    }
}
