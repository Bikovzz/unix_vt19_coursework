using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.;
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

    public String d, e, r;

    protected void OnBtnCalculateClicked(object sender, EventArgs e)
    {
        WebClient wc = new WebClient();
        String buff = wc.DownloadString("https://bank.gov.ua/ua/markets/exchangerates?date=30.09.2020&period=daily");
        d = System.Text.RegularExpressions.Regex.Match(buff, @"""US Dollar"",""rate"":""([0-9]+\,[0-9]+)""").Groups[1].Value;
        e = System.Text.RegularExpressions.Regex.Match(buff, @"""Euro"",""rate"":""([0-9]+\,[0-9]+)""").Groups[1].Value;
        r = System.Text.RegularExpressions.Regex.Match(buff, @"""Russian Ruble"",""rate"":""([0-9]+\,[0-9]+)""").Groups[1].Value;
    }
}
