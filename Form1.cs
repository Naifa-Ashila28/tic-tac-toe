namespace Tic_Tac_Toe_MK2
{
    public partial class Form1 : Form
    {
        bool turn = true; // true = X, false = O
        int turnCount = 0;

        public Form1()
        {
            InitializeComponent();

            btn1.Click += btn_Click;
            btn2.Click += btn_Click;
            btn3.Click += btn_Click;
            btn4.Click += btn_Click;
            btn5.Click += btn_Click;
            btn6.Click += btn_Click;
            btn7.Click += btn_Click;
            btn8.Click += btn_Click;
            btn9.Click += btn_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turnCount++;

            checkWinner();
        }

        private void checkWinner()
        {
            bool winner = false;

            // horizontal
            if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && (!btn1.Enabled))
                winner = true;
            else if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && (!btn4.Enabled))
                winner = true;
            else if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && (!btn7.Enabled))
                winner = true;

            // vertical
            else if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && (!btn1.Enabled))
                winner = true;
            else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && (!btn2.Enabled))
                winner = true;
            else if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && (!btn3.Enabled))
                winner = true;

            // diagonal
            else if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && (!btn1.Enabled))
                winner = true;
            else if ((btn3.Text == btn5.Text) && (btn5.Text == btn7.Text) && (!btn3.Enabled))
                winner = true;

            if (winner)
            {
                disableButtons();
                string winPlayer = turn ? "O" : "X";
                lblstatus.Text = "Pemenang: " + winPlayer;
            }
            else if (turnCount == 9)
            {
                lblstatus.Text = "Seri!";
            }
        }

        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                if (c is Button && c.Name.StartsWith("btn") && c.Name != "btnreset" && c.Name != "btnexit")
                {
                    ((Button)c).Enabled = false;
                }
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;
            lblstatus.Text = "Mulai permainan...";

            foreach (Control c in Controls)
            {
                if (c is Button && c.Name.StartsWith("btn") && c.Name != "btnreset" && c.Name != "btnexit")
                {
                    ((Button)c).Enabled = true;
                    ((Button)c).Text = "";
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
  
