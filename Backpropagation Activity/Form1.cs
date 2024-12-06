using Backprop;

namespace Backpropagation_Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NeuralNet orNN = new(2, 2, 1);

        private void btnOrCreate_Click(object sender, EventArgs e)
        {
            orNN = new NeuralNet(2, 2, 1);
        }
        private void btnOrTest_Click(object sender, EventArgs e)
        {
            orNN.setInputs(0, Convert.ToDouble(tbOrA.Text));
            orNN.setInputs(1, Convert.ToDouble(tbOrB.Text));
            orNN.run();
            tbOrResult.Text = "" + orNN.getOuputData(0).ToString("F7");
        }
        private void btnOrTrain_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 1000; x++)
            {
                orNN.setInputs(0, 0.0);
                orNN.setInputs(1, 0.0);
                orNN.setDesiredOutput(0, 0.0);
                orNN.learn();

                orNN.setInputs(0, 1.0);
                orNN.setInputs(1, 0.0);
                orNN.setDesiredOutput(0, 1.0);
                orNN.learn();

                orNN.setInputs(0, 0.0);
                orNN.setInputs(1, 1.0);
                orNN.setDesiredOutput(0, 1.0);
                orNN.learn();

                orNN.setInputs(0, 1.0);
                orNN.setInputs(1, 1.0);
                orNN.setDesiredOutput(0, 1.0);
                orNN.learn();
            }
        }


        const int HIDDEN = 4;
        const int EPOCH = 10000;
        NeuralNet andNN = new(4, HIDDEN, 1);
        private void btnAndCreate_Click(object sender, EventArgs e)
        {
            andNN = new(4, HIDDEN, 1);
        }

        private void btnAndTest_Click(object sender, EventArgs e)
        {
            andNN.setInputs(0, Convert.ToDouble(tbAndA.Text));
            andNN.setInputs(1, Convert.ToDouble(tbAndB.Text));
            andNN.setInputs(2, Convert.ToDouble(tbAndC.Text));
            andNN.setInputs(3, Convert.ToDouble(tbAndD.Text));
            andNN.run();
            tbAndResult.Text = "" + andNN.getOuputData(0).ToString("F7");
        }

        private void btnAndTrain_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < EPOCH; x++)
            {
                andNN.setDesiredOutput(0, 0.0);
                for (int y=0; y < 15; y++)
                {
                    andNN.setInputs(0, getBitDouble(y, 0));
                    andNN.setInputs(1, getBitDouble(y, 1));
                    andNN.setInputs(2, getBitDouble(y, 2));
                    andNN.setInputs(3, getBitDouble(y, 3));
                    andNN.learn();
                }
                andNN.setInputs(0, 1.0);
                andNN.setInputs(1, 1.0);
                andNN.setInputs(2, 1.0);
                andNN.setInputs(3, 1.0);
                andNN.setDesiredOutput(0, 1.0);
                andNN.learn();
            }
        }
        private double getBitDouble(int num, int pos)
        {
            int res = num & (1 << pos);
            if (res == 0)
                return 0.0;
            else
                return 1.0;
        }
    }
}
