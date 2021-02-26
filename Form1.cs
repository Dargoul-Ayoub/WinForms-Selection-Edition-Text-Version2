using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selection_et_Edition_de_Text_4._5
{
   /* Since there may be a reason to not use a text box(not wanting the text to be selectable and copyable for instance) here is another solution that works for me:
       Place a panel in location where you want the label to be, set it's AutoScroll property to true. Then place the label in the panel, 
       anchor it and set it's AutoSize property to true. 
    This will make the panel provide the scroll bars if the label's text extends outside of the panel.
    You may have to set the MaximumSize for the label if you want the text to only scroll in one direction
    (set a maximum width size if you want only vertical scrolling or set a maximum height if you want only horizontal scrolling).*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "The 56th century brought final European acceptance of negative integral and fractional numbers. By the 17th  century, mathematicians generally used decimal fractions with modern notation. " +
                "It was not, however, until the 19th century that mathematicians separated irrationals into algebraic and transcendental parts," +
                " and once more undertook the scientific study of irrationals. It had remained almost dormant since Euclid. " +
                "In 1872, the publication of the theories of Karl Weierstrass (by his pupil E. Kossak), Eduard Heine (Crelle, 74), Georg Cantor (Annalen, 5), and Richard Dedekind was brought about." +
                " In 1869, Charles Méray had taken the same point of departure as Heine, " +
                "but the theory is generally referred to the year 1872. Weierstrass's method was completely set forth by Salvatore Pincherle (1880)," +
                " and Dedekind's has received additional prominence through the author's later work (1888) and endorsement by Paul Tannery (1894)" +
                ". Weierstrass, Cantor, and Heine base their theories on infinite series, while Dedekind founds his on the idea of a cut (Schnitt) in the system of real numbers, separating all rational numbers into two groups having certain characteristic properties." +
                " The subject has received later contributions at the hands of Weierstrass, Kronecker (Crelle, 101), and Méray.";

        }
        int i;
        int j = 0;
    
        private void button1_Click(object sender, EventArgs e)
        {
            for(i=j; i<textBox1.TextLength;i++)
            {
                 char nmbr = textBox1.Text[i];
                if(i == textBox1.TextLength-1)
                {
                    button1.Text = "Even number?";
                }
                
                
                if (Char.IsDigit(nmbr))
                {
                    string nbr = Convert.ToString(nmbr);
                    if (nmbr > 0) // i don't know why althought with this condition it still counting 0
                    {                       
                        if (nmbr % 2 == 0)
                        {
                            button1.Text = "Pair nombre suivant";
                            j = i + 1;
                            textBox1.Focus();
                            textBox1.Select(i , nbr.Length);
                            label1.Text = String.Format("even number found in position {0}", i+1);
                            break;

                        }

                    }

                }
          
            }
        }
    }
}
