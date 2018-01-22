using System;
using TechTalk.SpecFlow;
using Ranorex;
using Ranorex.Core;
using System.Drawing;
using System.Windows.Forms;
using NUnit.Framework;

namespace com.edgewords.bdd.ranorex.Bindings
{
    
    [Binding]
    public class NewEntriesSteps
    {
        [Given(@"That I am logged in to KeePass")]
        public void GivenThatIAmLoggedInToKeePass()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Host.Local.RunApplication("C:\\Program Files (x86)\\KeePass Password Safe 2\\KeePass.exe", "", "C:\\Program Files (x86)\\KeePass Password Safe 2", false);
            Ranorex.Form LoginForm = "/form[@controlname='KeyPromptForm']";
            LoginForm.Activate();
            LoginForm.FindSingle<Ranorex.Text>(".//text[@accessiblerole='Text']").Click();
            LoginForm.FindSingle<Ranorex.Text>(".//text[@accessiblerole='Text']").PressKeys("password");
            LoginForm.FindSingle<Ranorex.Button>(".//button[@controlname='m_btnOK']").Click();
            Delay.Milliseconds(500);
        }

        [When(@"i add an entry to the '(.*)' category")]
        public void WhenIAddAnEntryToTheCategory(string p0)
        {
            Ranorex.Form MainForm = "/form[@controlname='MainForm']";
            MainForm.FindSingle<Ranorex.TreeItem>(".//treeitem[@accessiblename='"+p0+"']").Click();
            MainForm.FindSingle<Ranorex.Button>(".//button[@accessiblename='Add Entry']").Click();
            // move to the Add Entry form
            Ranorex.Form EntryForm = "/form[@controlname='PwEntryForm']";
            EntryForm.FindSingle<Ranorex.Text>(".//tabpage[@controlname='m_tabEntry']/text[@controlname='m_tbTitle']/text[@accessiblerole='Text']").Click();
            EntryForm.FindSingle<Ranorex.Text>(".//tabpage[@controlname='m_tabEntry']/text[@controlname='m_tbTitle']/text[@accessiblerole='Text']").PressKeys("edgewords");
            EntryForm.FindSingle<Ranorex.Text>(".//tabpage[@controlname='m_tabEntry']/?/?/text[@accessiblename='User name:']").Click();
            EntryForm.FindSingle<Ranorex.Text>(".//tabpage[@controlname='m_tabEntry']/?/?/text[@accessiblename='User name:']").PressKeys("edge");
            EntryForm.FindSingle<Ranorex.Button>(".//button[@controlname='m_btnOK']").Click();
            Delay.Milliseconds(2000);
        }

        [Then(@"the entry should be listed in the main table")]
        public void ThenTheEntryShouldBeListedInTheMainTable()
        {
            Cell theCell;
            bool isCellThere = Host.Local.TryFindSingle("/form[@controlname='MainForm']/.//table[@controlname='m_lvEntries']/?/?/cell[@text='edgewords']", out theCell);
            Assert.That (isCellThere, "edgewords entry not found in the table!");
        }
    }
}
