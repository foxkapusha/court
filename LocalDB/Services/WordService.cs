using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace LocalDB.Services
{
    public class WordService
    {
        public static string GetPath()
        {
            var result = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            return Path.GetDirectoryName(result);
        }

        public void GenerateNotification(string caseText, string whoMultiline, string tbCaseText, string who, string actionText, string dateTime)
        {
            DocX doc = DocX.Load(Path.Combine(GetPath(), "извещение.docx"));
            
            doc.Bookmarks["casedate"].SetText(caseText);
            doc.Bookmarks["actiontype"].SetText(actionText);
            doc.Bookmarks["whomultiline"].SetText(whoMultiline);
            doc.Bookmarks["who"].SetText(who);
            doc.Bookmarks["casedatetime"].SetText(dateTime);
            doc.Bookmarks["casenumber"].SetText(tbCaseText);

            string fileName = "temp/" + Path.GetRandomFileName() + ".docx";
            fileName = Path.Combine(GetPath(), fileName);
            doc.SaveAs(fileName);

            System.Diagnostics.Process.Start(fileName);
        }

        public void GenerateAgenda(string caseText, string judjeText, string whotypeText, 
            string hoursText, string monthText, string yearText, string casenumber2Text, 
            string addressText, string whereaddressText, string whotosendText, string secretarText)
        {
            DocX doc = DocX.Load(Path.Combine(GetPath(), "Судебная повестка.docx"));

            doc.Bookmarks["casenumber"].SetText(caseText);
            doc.Bookmarks["judje"].SetText(judjeText);
            doc.Bookmarks["whotype"].SetText(whotypeText);
            doc.Bookmarks["hours"].SetText(hoursText);
            doc.Bookmarks["month"].SetText(monthText);
            doc.Bookmarks["year"].SetText(yearText);
            doc.Bookmarks["casenumber2"].SetText(casenumber2Text);
            doc.Bookmarks["address"].SetText(addressText);
            doc.Bookmarks["whereaddress"].SetText(whereaddressText);
            doc.Bookmarks["whotosend"].SetText(whotosendText);
            doc.Bookmarks["secretar"].SetText(secretarText);

            string fileName = "temp/" + Path.GetRandomFileName() + ".docx";
            fileName = Path.Combine(GetPath(), fileName);
            doc.SaveAs(fileName);

            System.Diagnostics.Process.Start(fileName);
        }

        public void GenerateNotice(string caseText, string who, string address, string staffName, string days)
        {
            DocX doc = DocX.Load(Path.Combine(GetPath(), "уведомление.docx"));

            doc.Bookmarks["casedate"].SetText(caseText);
            doc.Bookmarks["who"].SetText(who);
            doc.Bookmarks["whoaddress"].SetText(address);
            doc.Bookmarks["staffname"].SetText(staffName);
            doc.Bookmarks["days"].SetText(days);

            string fileName = "temp/" + Path.GetRandomFileName() + ".docx";
            fileName = Path.Combine(GetPath(), fileName);
            doc.SaveAs(fileName);

            System.Diagnostics.Process.Start(fileName);
        }

        public void GenerateDecision(string caseText, string caseNumber, string staffName,
            string caseDate, string istetsName, string istetsAddress, string otvetchikName, 
            string otvetchikAddress)
        {
            DocX doc = DocX.Load(Path.Combine(GetPath(), "сопроводительная.docx"));

            doc.Bookmarks["casefullname"].SetText(caseText);
            doc.Bookmarks["casenumber2"].SetText(caseNumber);
            doc.Bookmarks["staffname"].SetText(staffName);
            doc.Bookmarks["casedate"].SetText(caseDate);
            doc.Bookmarks["istetsaddress"].SetText(istetsAddress);
            doc.Bookmarks["istetsname"].SetText(istetsName);
            doc.Bookmarks["otvetchikaddress"].SetText(otvetchikAddress);
            doc.Bookmarks["otvetchikname"].SetText(otvetchikName);

            string fileName = "temp/" + Path.GetRandomFileName() + ".docx";
            fileName = Path.Combine(GetPath(), fileName);
            doc.SaveAs(fileName);

            System.Diagnostics.Process.Start(fileName);
        }
    }
}
