using System;
using System.Windows.Forms;
using WordCounterLibrary;

namespace WordCounterGui
{
    public partial class WordCounterGui : Form
    {
        WordCounter counter = new WordCounter();
        public WordCounterGui()
        {
            InitializeComponent();
        }


        private void WordCounter_Load(object sender, EventArgs e)
        {

        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            CountWords();
        }

        private void WhiteSpaceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            counter.countWhiteSpaces = !counter.countWhiteSpaces;
            CountWords();
        }

        private void CountWords()
        {
            string text = UserText.Text;

            counter.Count(text);

            WordCountLabel.Text = string.Format("Words: {0}", counter.wordCount);
            CharCountLabel.Text = string.Format("Characters: {0}", counter.charCount);

            counter.Reset();
        }
    }
}
