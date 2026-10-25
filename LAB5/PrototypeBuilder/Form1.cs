using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrototypeBuilder
{
    public partial class Form1 : Form
    {
        private OutfitBuilder builder;
        private OutfitDirector director;
        private Outfit currentOutfit = null;
        private List<Outfit> clonedOutfits = new List<Outfit>();
        private int currentStep = 0;
        private string currentOutfitType = "Повсякденний";

        public Form1()
        {
            InitializeComponent();
            director = new OutfitDirector();
            builder = new CasualOutfitBuilder();
            director.setBuilder(builder);
            cmbOutfitType.SelectedIndex = 0;
        }

        private void cmbOutfitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentStep = 0;
            currentOutfit = null;
            rtbDetails.Clear();
            rtbLog.Clear();

            if (cmbOutfitType.SelectedIndex == 0)
            {
                builder = new CasualOutfitBuilder();
                currentOutfitType = "Повсякденний";
            }
            else if (cmbOutfitType.SelectedIndex == 1)
            {
                builder = new BusinessOutfitBuilder();
                currentOutfitType = "Діловий";
            }
            else if (cmbOutfitType.SelectedIndex == 2)
            {
                builder = new SportsOutfitBuilder();
                currentOutfitType = "Спортивний";
            }

            director.setBuilder(builder);
            rtbLog.AppendText("Обрано тип комплекту: " + currentOutfitType + "\n");
            btnNextStep.Enabled = true;
            btnClone.Enabled = false;
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            if (currentStep > 6)
            {
                return;
            }

            switch (currentStep)
            {
                case 0:
                    builder.reset();
                    rtbLog.AppendText("Крок 1: reset() — створено новий порожній комплект.\n");
                    break;
                case 1:
                    builder.buildOuterwear();
                    rtbLog.AppendText("Крок 2: buildOuterwear() — додано верхній одяг.\n");
                    break;
                case 2:
                    builder.buildTop();
                    rtbLog.AppendText("Крок 3: buildTop() — додано верх.\n");
                    break;
                case 3:
                    builder.buildBottom();
                    rtbLog.AppendText("Крок 4: buildBottom() — додано низ.\n");
                    break;
                case 4:
                    builder.buildFootwear();
                    rtbLog.AppendText("Крок 5: buildFootwear() — додано взуття.\n");
                    break;
                case 5:
                    builder.buildAccessories();
                    rtbLog.AppendText("Крок 6: buildAccessories() — додано аксесуари.\n");
                    break;
            }

            currentStep++;

            if (currentStep == 6)
            {
                currentOutfit = builder.getResult();
                rtbDetails.Text = currentOutfit.showDetails();
                rtbLog.AppendText("Комплект повністю зібрано. Викликано getResult().\n");
                btnNextStep.Enabled = false;
                btnClone.Enabled = true;
            }
            else
            {
                Outfit temp = builder.getResult();
                if (temp != null)
                {
                    rtbDetails.Text = temp.showDetails();
                }
            }
        }

        private void btnBuildAll_Click(object sender, EventArgs e)
        {
            switch (cmbOutfitType.SelectedIndex)
            {
                case 0:
                    director.constructCasualOutfit();
                    break;
                case 1:
                    director.constructBusinessOutfit();
                    break;
                case 2:
                    director.constructSportsOutfit();
                    break;
            }

            currentOutfit = builder.getResult();
            rtbLog.AppendText("Виконано автоматичну збірку через OutfitDirector.\n");
            rtbDetails.Text = currentOutfit.showDetails();
            currentStep = 6;
            btnNextStep.Enabled = false;
            btnClone.Enabled = true;
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            if (currentOutfit == null)
            {
                MessageBox.Show("Спочатку створіть комплект!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Outfit copy = currentOutfit.clone();
            clonedOutfits.Add(copy);
            lstClones.Items.Add("Копія #" + clonedOutfits.Count.ToString() + " [" + currentOutfitType + "]");
            rtbLog.AppendText("Викликано clone(). Створено копію #" + clonedOutfits.Count.ToString() + ".\n");
        }

        private void lstClones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClones.SelectedIndex < 0 || lstClones.SelectedIndex >= clonedOutfits.Count)
            {
                return;
            }

            rtbCloneDetails.Text = clonedOutfits[lstClones.SelectedIndex].showDetails();
        }
    }
}