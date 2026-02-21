using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Project__Word_Game_
{
    public partial class WhatDidIMiss : Form
    {
        public string[] definitions;
        public WhatDidIMiss(string[] missedWords)
        {
            InitializeComponent();
            WordList.Items.Clear();

            foreach (string word in missedWords)
            {
                WordList.Items.Add(word);
            }

        }
        private void DefineButton_Click(object sender, EventArgs e)
        {
            GetDefinition(WordList.SelectedItem.ToString());
        }
        private async Task GetDefinition(string word)
        {
            DefinitionLookup lookup = new DefinitionLookup();
            MessageBox.Show(await lookup.GetDefinitionAsync(word));
        }
        private void WordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefineButton.Enabled = true;
        }
    }
}