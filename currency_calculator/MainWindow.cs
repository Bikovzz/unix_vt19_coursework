using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.IO;
using System.Net;
using Gtk;


public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnBtnCalculateClicked(object sender, EventArgs e)
    {
        String usd, eur, rub;
        WebClient wc = new WebClient();
        String buff = wc.DownloadString("https://bank.gov.ua/ua/markets/exchangerates?date=19.07.2021&period=daily");
        usd = System.Text.RegularExpressions.Regex.Match(buff, @"""US Dollar"",""rate"":""([0-9]+\,[0-9]+)""").Groups[1].Value;
        eur = System.Text.RegularExpressions.Regex.Match(buff, @"""Euro"",""rate"":""([0-9]+\,[0-9]+)""").Groups[1].Value;
        rub = System.Text.RegularExpressions.Regex.Match(buff, @"""Russian Ruble"",""rate"":""([0-9]+\,[0-9]+)""").Groups[1].Value;
        double k = 0, dob_val;
        string value;
        if (cmbFrom.ActiveText.ToString() == "EUR" && cmbTo.ActiveText.ToString() == "USD")
        {
            k = Convert.ToDouble(eur) / Convert.ToDouble(usd);
        }
        else if (cmbFrom.ActiveText.ToString() == "EUR" && cmbTo.ActiveText.ToString() == "RUB")
        {
            k = Convert.ToDouble(eur) / (1 / Convert.ToDouble(rub));
        }
        else if (cmbFrom.ActiveText.ToString() == "EUR" && cmbTo.ActiveText.ToString() == "UAH")
        {
            k = Convert.ToDouble(eur);
        }
        else if (cmbFrom.ActiveText.ToString() == "USD" && cmbTo.ActiveText.ToString() == "EUR")
        {
            k = Convert.ToDouble(usd) / Convert.ToDouble(eur);
        }
        else if (cmbFrom.ActiveText.ToString() == "USD" && cmbTo.ActiveText.ToString() == "RUB")
        {
            k = Convert.ToDouble(usd) / (1 / Convert.ToDouble(rub));
        }
        else if (cmbFrom.ActiveText.ToString() == "USD" && cmbTo.ActiveText.ToString() == "UAH")
        {
            k = Convert.ToDouble(usd);
        }
        else if (cmbFrom.ActiveText.ToString() == "RUB" && cmbTo.ActiveText.ToString() == "EUR")
        {
            k = (1 / Convert.ToDouble(rub)) / Convert.ToDouble(eur);
        }
        else if (cmbFrom.ActiveText.ToString() == "RUB" && cmbTo.ActiveText.ToString() == "USD")
        {
            k = (1 / Convert.ToDouble(rub)) / Convert.ToDouble(usd);
        }
        else if (cmbFrom.ActiveText.ToString() == "RUB" && cmbTo.ActiveText.ToString() == "UAH")
        {
            k = 1 / Convert.ToDouble(rub);
        }
        else if (cmbFrom.ActiveText.ToString() == "UAH" && cmbTo.ActiveText.ToString() == "RUB")
        {
            k = Convert.ToDouble(rub);
        }
        else if (cmbFrom.ActiveText.ToString() == "UAH" && cmbTo.ActiveText.ToString() == "USD")
        {
            k = 1 / Convert.ToDouble(usd);
        }
        else if (cmbFrom.ActiveText.ToString() == "UAH" && cmbTo.ActiveText.ToString() == "EUR")
        {
            k = 1 / Convert.ToDouble(usd);
        }
        else if (cmbFrom.ActiveText.ToString() == cmbTo.ActiveText.ToString())
        {
            k = 1;
        }
        else
        {
            k = 0;
        }
        value = entValue.Text.ToString();
        bool success = Double.TryParse(value, out dob_val);
        if (k > 0 && success == true)
        {
            lblResult.Text = (Convert.ToDouble(value) * k).ToString();
        }
        else if (!success)
        {
            lblResult.Text = "Incorrect value!";
        }
    }
}
