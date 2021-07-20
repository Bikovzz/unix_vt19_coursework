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

    public String usd, eur, rub;

    protected void OnBtnCalculateClicked(object sender, EventArgs e)
    {
        WebClient wc = new WebClient();
        String buff = wc.DownloadString("https://bank.gov.ua/ua/markets/exchangerates?date=19.07.2021&period=daily");
        usd = System.Text.RegularExpressions.Regex.Match(buff, @"""US Dollar"",""rate"":""([0-9]+\,[0-9]+)""").Groups[1].Value;
        eur = System.Text.RegularExpressions.Regex.Match(buff, @"""Euro"",""rate"":""([0-9]+\,[0-9]+)""").Groups[1].Value;
        rub = System.Text.RegularExpressions.Regex.Match(buff, @"""Russian Ruble"",""rate"":""([0-9]+\,[0-9]+)""").Groups[1].Value;
        int k = 0;
        if (cmbFrom.ActiveText.ToString() == "EUR" && cmbTo.ActiveText.ToString() == "USD")
        {
            k = Convert.ToInt32(eur) / Convert.ToInt32(usd);
        }
        else if (cmbFrom.ActiveText.ToString() == "EUR" && cmbTo.ActiveText.ToString() == "RUB")
        {
            k = Convert.ToInt32(eur) / Convert.ToInt32(rub);
        }
        else if (cmbFrom.ActiveText.ToString() == "EUR" && cmbTo.ActiveText.ToString() == "UAH")
        {
            k = Convert.ToInt32(eur);
        }
        else if (cmbFrom.ActiveText.ToString() == "USD" && cmbTo.ActiveText.ToString() == "EUR")
        {
            k = Convert.ToInt32(usd) / Convert.ToInt32(eur);
        }
        else if (cmbFrom.ActiveText.ToString() == "USD" && cmbTo.ActiveText.ToString() == "RUB")
        {
            k = Convert.ToInt32(usd) / Convert.ToInt32(rub);
        }
        else if (cmbFrom.ActiveText.ToString() == "USD" && cmbTo.ActiveText.ToString() == "UAH")
        {
            k = Convert.ToInt32(usd);
        }
        else if (cmbFrom.ActiveText.ToString() == "RUB" && cmbTo.ActiveText.ToString() == "EUR")
        {
            k = Convert.ToInt32(rub) / Convert.ToInt32(eur);
        }
        else if (cmbFrom.ActiveText.ToString() == "RUB" && cmbTo.ActiveText.ToString() == "USD")
        {
            k = Convert.ToInt32(rub) / Convert.ToInt32(usd);
        }
        else if (cmbFrom.ActiveText.ToString() == "RUB" && cmbTo.ActiveText.ToString() == "UAH")
        {
            k = Convert.ToInt32(rub);
        }
        else if (cmbFrom.ActiveText.ToString() == "UAH" && cmbTo.ActiveText.ToString() == "RUB")
        {
            k = 1 / Convert.ToInt32(rub);
        }
        else if (cmbFrom.ActiveText.ToString() == "UAH" && cmbTo.ActiveText.ToString() == "USD")
        {
            k = 1 / Convert.ToInt32(usd);
        }
        else if (cmbFrom.ActiveText.ToString() == "RUB" && cmbTo.ActiveText.ToString() == "EUR")
        {
            k = 1 / Convert.ToInt32(usd);
        }
        else
        {
            k = 0;
        }
    }
}
