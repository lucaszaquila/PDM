using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TP02.Global
{
    class EntryNumerico : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            int parsed;
            bool validar = int.TryParse(sender.Text, out parsed);
            if (!validar)
            {
                sender.TextColor = Color.Red;
            }
            else
            {
                sender.TextColor = Color.Blue;
            }
        }
    }
}
