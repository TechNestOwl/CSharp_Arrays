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
            //1.) Create an Empty Array of 100 integers.
            //2.) Fill this Array with all 0’s(zeros).Use a Loop. 
            //3.) Print out the 100 values stored in the Array to the Console(Output) Window.Use a Loop.
            
            //initializng my empty array of 100 integers
            int[] zerosArray = new int[100];

            //looping through and setting each i to 0
            for (int i = 0;i < zerosArray.Length; i++)
            {
                zerosArray[i] = 0;
            }
            //outputing to debubbing console
            System.Diagnostics.Debug.WriteLine(zerosArray);


        }

        private void problem2Btn_Click(object sender, EventArgs e)
        {
            /*
             * 1.)	Create an Empty Array of 100 integers.   
                2.)	Fill this Array with the numbers 500-599.  Use a Loop. 
                3.)	Print out the 100 values stored in the Array to the Console(Output) Window. Use a Loop.
             */
        }

        private void problem3Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
