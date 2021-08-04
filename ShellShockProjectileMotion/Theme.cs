using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Themes
{
    public class Theme
    {
        public Themes currentTheme;
        private ThemeTemplate themeCollection;
        public enum Themes
        {
            White,
            Black
        }


        public void LoadJson()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "//themes.json";

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                themeCollection = JsonConvert.DeserializeObject<ThemeTemplate>(json);
            }
        }

        public void SetTheme(Themes theme, Control control)
        {
            foreach (Control cc in control.Controls)
            {
                SetTheme(theme, cc);
            }

            switch (theme)
            {
                case Themes.White:
                    control.BackColor = ColorTranslator.FromHtml(themeCollection.white.Form);
                    currentTheme = Themes.White;
                    foreach (Control c in control.Controls)
                    {
                        c.ForeColor = ColorTranslator.FromHtml(themeCollection.white.Text);
                        switch (c)
                        {
                            case Panel p:
                                p.BackColor = ColorTranslator.FromHtml(themeCollection.white.Panel);
                                break;
                            case TextBox t:
                                t.BackColor = ColorTranslator.FromHtml(themeCollection.white.TextBox);
                                t.ForeColor = ColorTranslator.FromHtml(themeCollection.white.Text);
                                break;
                            case Button b:
                                b.BackColor = ColorTranslator.FromHtml(themeCollection.white.Button);
                                switch (b.Tag)
                                {
                                    case "DELETE":
                                        b.FlatAppearance.BorderColor = Color.Red;
                                        break;
                                    case "BUMPER":
                                        b.FlatAppearance.BorderColor = Color.Violet;
                                        break;
                                    default:
                                        b.FlatAppearance.BorderColor = ColorTranslator.FromHtml(themeCollection.white.Border);
                                        break;
                                }
                                break;
                            case Label l:
                                l.BackColor = Color.Transparent;
                                break;
                        }
                    }
                    break;
                case Themes.Black:
                    control.BackColor = ColorTranslator.FromHtml(themeCollection.black.Form);
                    currentTheme = Themes.Black;
                    foreach (Control c in control.Controls)
                    {
                        c.ForeColor = ColorTranslator.FromHtml(themeCollection.black.Text);
                        switch (c)
                        {
                            case Panel p:
                                p.BackColor = ColorTranslator.FromHtml(themeCollection.black.Panel);
                                break;
                            case TextBox t:
                                t.BackColor = ColorTranslator.FromHtml(themeCollection.black.TextBox);
                                t.ForeColor = ColorTranslator.FromHtml(themeCollection.black.Text);
                                break;
                            case Button b:
                                b.BackColor = ColorTranslator.FromHtml(themeCollection.black.Button);
                                switch (b.Tag)
                                {
                                    case "DELETE":
                                        b.FlatAppearance.BorderColor = Color.Red;
                                        break;
                                    case "BUMPER":
                                        b.FlatAppearance.BorderColor = Color.Violet;
                                        break;
                                    default:
                                        b.FlatAppearance.BorderColor = ColorTranslator.FromHtml(themeCollection.white.Border);
                                        break;
                                }
                                break;
                            case Label l:
                                l.BackColor = Color.Transparent;
                                break;
                        }
                    }
                    break;
            }
        }
    }
}
