using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gnuciDictionary;
namespace Deficiando
{
    public partial class Definiciando : Form
    {
        int winningdefbox = 0;
        int score = 0;
        int numwordstried = 0;
        //formlevelvariables: numwordstried, score, correct-definition 
        //enum pickaword, chosedefinition, pressenter
        private enum GameStateEnum { pickword, choosedefinition, userwent, }
        GameStateEnum gamestate = GameStateEnum.pickword;
        List<Word> lstwords;
        Random rndWord = new Random();
        Random rndDefBox = new Random();
        Word selectedword;
        List<Word> words;
        List<Label> lstedefboxes = new List<Label>();

        public Definiciando()
        {
            InitializeComponent();
            btnPickWord.Click += BtnPickWord_Click;
            lstwords = EnglishDictionary.GetAllWords().ToList();
            lstedefboxes = new List<Label>() {  lblDef1, lblDef2, lblDef3 };
            btnEnter.Click += BtnEnter_Click1;
            btnGiveUp.Click += BtnGiveUp_Click;
            SetButtonsEnabled();
        }

        private void BtnEnter_Click1(object? sender, EventArgs e)
        {
            this.CheckWinner();
        }

        private void PickaWord()
        {
            int wordnum = rndWord.Next(1000, 100000);
            gamestate = GameStateEnum.choosedefinition;
            ClearHighlightDefBoxes();
            numwordstried += 1;
            DisplayScore();
            winningdefbox = rndDefBox.Next(0, 3);
            selectedword = lstwords[wordnum];

            lblWord.Text = selectedword.Value;

            lstedefboxes.ForEach(l => l.Text = "");

            lstedefboxes[winningdefbox].Text = selectedword.Definition;

            lstedefboxes.Where(l => l.Text == "").ToList().ForEach(l =>
            {
                //pick a random word and put its definition into the l
                wordnum = rndWord.Next(0, 100000);
                l.Text = lstwords[wordnum].Definition;
            });
            SetButtonsEnabled();
        }

        private void DisplayScore()
        {
            //lblNumWords.Text = numwordstried.ToString();
            lblScore.Text = score.ToString();
        }

        private void DisplayMessage(string value)
        {
            lblMessage.Text = value;
        }
        private void CheckWinner()
        {
            int selectradiobutton = 0;
            gamestate = GameStateEnum.userwent;
            if (optDef2.Checked == true)
            {
                selectradiobutton = 1;
            }
            else if (optDef3.Checked == true)
            {
                selectradiobutton = 2;
            }

            if (winningdefbox == selectradiobutton)
            {
                score += 1;
                DisplayMessage("You GOT IT!!!!!!!!!!!!!!!!!!!");
            }
            else
            {
                score -= 1;
                DisplayMessage("You lose!!!!!!!! Try again.");
            }
            DisplayScore();
            HighlightCorrectDefinition();
            SetButtonsEnabled();
        }

        private void GiveUp()
        {
            HighlightCorrectDefinition();
            gamestate = GameStateEnum.userwent;
            SetButtonsEnabled();
        }

        private void ClearHighlightDefBoxes()
        {
            lstedefboxes.ForEach(l => l.BackColor = Color.Ivory);
        }

        private void HighlightCorrectDefinition()
        {
            lstedefboxes[winningdefbox].BackColor = Color.LightBlue;

        }

        private void SetButtonsEnabled()
        {
            switch (gamestate)
            {
                case GameStateEnum.pickword:
                case GameStateEnum.userwent:
                    btnEnter.Enabled = false;
                    btnPickWord.Enabled = true;
                    btnGiveUp.Enabled = false;
                    break;
                case GameStateEnum.choosedefinition:
                    btnEnter.Enabled = true;
                    btnPickWord.Enabled = false;
                    btnGiveUp.Enabled = true;
                    break;
            }
        }

        private void BtnPickWord_Click(object? sender, EventArgs e)
        {
            PickaWord();
        }

        private void BtnGiveUp_Click(object? sender, EventArgs e)
        {
            this.GiveUp();
        }
    }
}