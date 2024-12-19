using System.Windows.Markup;

namespace Calculette
{
    public partial class Form1 : Form
    {
        List<float> values = new List<float>();
        List<string> operators = new List<string>();
        public Form1()
        {

            InitializeComponent();

        }

        // Gestion des opérateurs
        private void calc_btn_plus_Click(object sender, EventArgs e)
        {
            ajouterOperateur("+");
        }

        private void calc_btn_minus_Click(object sender, EventArgs e)
        {
            ajouterOperateur("-");
        }

        private void calc_btn_multi_Click(object sender, EventArgs e)
        {
            ajouterOperateur("*");
        }

        private void calc_btn_div_Click(object sender, EventArgs e)
        {
            ajouterOperateur("/");
        }

        private void calc_btn_modulo_Click(object sender, EventArgs e)
        {
            ajouterOperateur("%");
        }
        private void win_calc_carre_Click(object sender, EventArgs e)
        {
            ajouterOperateur("^2");
        }

        private void win_calc_racine_Click(object sender, EventArgs e)
        {
            ajouterOperateur("√");
        }

        // Gestion du bouton égal
        private void calc_btn_equal_Click(object sender, EventArgs e)
        {
            string tempText = calculator_text.Text;
            try
            {
                // Ajout de la dernière valeur si elle n'est pas vide
                if (!string.IsNullOrEmpty(calculator_text.Text) && !expectNegativeNumber)
                {
                    values.Add(float.Parse(calculator_text.Text));
                }

                Console.WriteLine("Values : ");
                Console.WriteLine(string.Join(",", values));
                Console.WriteLine("Operators : ");
                Console.WriteLine(string.Join(",", operators));

                // Reset de la calculatrice
                calculator_text.Text = "";
                win_calculator_text.Text = "";

                // Création de l'historique
                for (int i = 0; i <= operators.Count; i++)
                {
                    if (i == operators.Count)
                    {
                        historyTextBox.Text += values[i].ToString();
                    }
                    else
                    {
                        historyTextBox.Text += values[i].ToString() + operators[i];
                    }
                }

                // Gérer les opérations "speciales"



                // Les puissances
                for (int i = 0; i < operators.Count; i++)
                {
                    if (operators[i] == "^2")
                    {

                        //Valeur à la position 'i' par le résultat de la puissance
                        values[i] = (float)Math.Pow(values[i], 2);

                        // Supprimer l'opérateur
                        // car on a déjà calculé la puissance
                        operators.RemoveAt(i);
                        i--;
                    }
                }

                // Les racines carrées
                for (int i = 0; i < operators.Count; i++)
                {
                    if (operators[i] == "√")
                    {
                        values[i] = (float)Math.Sqrt(values[i]);

                        // Supprimer l'opérateur
                        // car on a déjà calculé la racine carrée
                        operators.RemoveAt(i);
                        if (i + 1 < values.Count) // Si autre valeur après la racine carrée
                        {
                            values.RemoveAt(i + 1); // Supprimez la valeur
                        }
                        i--;
                    }
                }

                // Les multiplications, divisions et modules
                for (int i = 0; i < operators.Count; i++)
                {
                    if (operators[i] == "*" || operators[i] == "/" || operators[i] == "%")
                    {
                        float valeurGauche = values[i];
                        float valeurDroite = values[i + 1];
                        float resultatTemp = 0;

                        switch (operators[i])
                        {
                            case "*":
                                resultatTemp = valeurGauche * valeurDroite;
                                break;
                            case "/":
                                resultatTemp = valeurGauche / valeurDroite;
                                break;
                            case "%":
                                resultatTemp = valeurGauche % valeurDroite;
                                break;
                        }

                        // Remplacer la valeur à la position 'i' par le résultat de l'opération
                        // et supprimer l'opérateur et la valeur suivante
                        values[i] = resultatTemp;
                        operators.RemoveAt(i);
                        if (i + 1 < values.Count) // Si autre valeur après l'opérateur
                        {
                            values.RemoveAt(i + 1); // Supprimez la valeur qui suit l'opérateur
                        }
                        i--;
                    }
                }

                // Les additions et soustractions
                float result = values[0]; // Prendre la première valeur comme base
                for (int i = 0; i < operators.Count; i++)
                {
                    if (i + 1 < values.Count) // Si autre valeur après l'opérateur
                    {
                        switch (operators[i])
                        {
                            case "+":
                                result += values[i + 1];
                                break;
                            case "-":
                                result -= values[i + 1];
                                break;
                        }
                    }
                }

                // Affichage du résultat
                calculator_text.Text = result.ToString();
                win_calculator_text.Text = result.ToString();
                historyTextBox.Text += " = " + result.ToString() + "\n";
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                // Affichage de l'erreur
                calculator_text.Text = "Erreur Syntaxe";
                win_calculator_text.Text = "Erreur Syntaxe";
            }

            // Reset des valeurs
            operators.Clear();
            values.Clear();

        }




        // Gestion d'ajout des nombres
        private void ajouterNombre(float nombre)
        {
            // Gère l'ajout d'un nombre s'il est précédé d'un signe négatif
            if (expectNegativeNumber)
            {
                calculator_text.Text += nombre.ToString();  // Concaténer le nombre avec le signe "-"
                win_calculator_text.Text += nombre.ToString();
                expectNegativeNumber = false;  // Une fois le nombre ajouté, on ne s'attend plus à un nombre négatif
            }
            else
            {
                if (calculator_text.Text != "Erreur Syntaxe" && win_calculator_text.Text != "Erreur Syntaxe")
                {
                    calculator_text.Text += nombre.ToString();
                    win_calculator_text.Text += nombre.ToString();
                }
                else
                {
                    calculator_text.Text = nombre.ToString();
                    win_calculator_text.Text = nombre.ToString();
                }
            }
        }



        // Gestion de la virgule
        private void ajouterDot()
        {
            if (calculator_text.Text != "Erreur Syntaxe")
            {
                calculator_text.Text += ",";
                win_calculator_text.Text += ",";
            }
            else
            {
                calculator_text.Text = ",";
                win_calculator_text.Text = ",";
            }
        }

        // Gestion des opérateurs
        // booléen permettant de savoir si on attend un nombre négatif après un opérateur
        // pour eviter les erreurs sur les opérations de type 5*-5
        bool expectNegativeNumber = false;

        private void ajouterOperateur(string operateur)
        {
            if (calculator_text.Text == "Erreur Syntaxe")
            {
                calculator_text.Text = "";
                win_calculator_text.Text = "";
            }

            // Si c'est le tout premier caractère et que l'utilisateur entre "-", traiter cela comme un nombre négatif
            if (operateur == "-" && string.IsNullOrEmpty(calculator_text.Text) && values.Count == 0)
            {
                expectNegativeNumber = true;
                calculator_text.Text = "-";
                win_calculator_text.Text += "-";
                return; // On attend encore un chiffre, donc on arrête ici
            }

            // Vérifie si on attend un nombre négatif après un opérateur comme *, /, ou autre
            if (operateur == "-" && !string.IsNullOrEmpty(calculator_text.Text))
            {
                // Si l'opérateur précédent est *, /, %, le signe "-" est un signe de nombre négatif
                if (operators.Count > 0 && (operators.Last() == "*" || operators.Last() == "/" || operators.Last() == "%"))
                {
                    expectNegativeNumber = true;
                    calculator_text.Text = "-";
                    win_calculator_text.Text += "-";
                    return;
                }
            }

            // Si ce n'est pas un nombre négatif en attente, on ajoute le nombre dans la liste
            if (!string.IsNullOrEmpty(calculator_text.Text) && !expectNegativeNumber)
            {
                values.Add(float.Parse(calculator_text.Text));
            }

            operators.Add(operateur);
            calculator_text.Text = "";  // Réinitialise la zone de texte pour la prochaine entrée
            win_calculator_text.Text += operateur;

            expectNegativeNumber = false; // On désactive le mode nombre négatif après l'ajout de l'opérateur
        }




        // Gestion des boutons des chiffres
        private void calc_btn_0_Click(object sender, EventArgs e)
        {
            ajouterNombre(0);
        }

        private void calc_btn_1_Click(object sender, EventArgs e)
        {
            ajouterNombre(1);
        }

        private void calc_btn_2_Click(object sender, EventArgs e)
        {
            ajouterNombre(2);
        }

        private void calc_btn_3_Click(object sender, EventArgs e)
        {
            ajouterNombre(3);
        }

        private void calc_btn_4_Click(object sender, EventArgs e)
        {
            ajouterNombre(4);
        }

        private void calc_btn_5_Click(object sender, EventArgs e)
        {
            ajouterNombre(5);
        }

        private void calc_btn_6_Click(object sender, EventArgs e)
        {
            ajouterNombre(6);
        }

        private void calc_btn_7_Click(object sender, EventArgs e)
        {
            ajouterNombre(7);
        }

        private void calc_btn_8_Click(object sender, EventArgs e)
        {
            ajouterNombre(8);
        }

        private void calc_btn_9_Click(object sender, EventArgs e)
        {
            ajouterNombre(9);
        }

        // Boutons spéciaux
        private void calc_btn_clear_Click(object sender, EventArgs e)
        {
            // Reset de la calculatrice
            values.Clear();
            operators.Clear();
            calculator_text.Text = "";
            win_calculator_text.Text = "";
        }

        private void calc_btn_remove_Click(object sender, EventArgs e)
        {
            // Suppression du dernier caractère
            try
            {
                char lastChar = win_calculator_text.Text[win_calculator_text.Text.Length - 1];
                if (Char.IsDigit(lastChar))
                {
                    win_calculator_text.Text = win_calculator_text.Text.Remove(win_calculator_text.Text.Length - 1);

                    if (!string.IsNullOrEmpty(calculator_text.Text))
                    {
                        calculator_text.Text = calculator_text.Text.Remove(calculator_text.Text.Length - 1);
                    }
                    else
                    {
                        values.RemoveAt(values.Count - 1);
                    }
                }
                else
                {
                    // Si c'est un opérateur
                    operators.RemoveAt(operators.Count - 1);
                    win_calculator_text.Text = win_calculator_text.Text.Remove(win_calculator_text.Text.Length - 1);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void calc_btn_dot_Click(object sender, EventArgs e)
        {
            ajouterDot();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calc_change_sign_Click(object sender, EventArgs e)
        {
            // Changement de signe
            if (calculator_text.Text != "" && calculator_text.Text != "Erreur Syntaxe")
            {
                float value = float.Parse(calculator_text.Text);
                value *= -1;
                calculator_text.Text = value.ToString();
                win_calculator_text.Text = value.ToString();
            }
        }

        private void style_choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Changement de style
            if (style_choice.Text == "MacOS")
            {
                windows_style.Visible = false;
                macos_style.Visible = true;
            }
            else
            {
                windows_style.Visible = true;
                macos_style.Visible = false;
            }
        }

        private void historyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (historyCheckbox.Checked)
            {
                historyTextBox.Visible = true;
            } else
            {
                historyTextBox.Visible = false;
            }
        }
    }
}
