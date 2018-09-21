using DevExpress.Utils;
using DevExpress.Utils.Design;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_CellStyleProvider {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dateEdit1.DateTime = calendarControl1.DateTime = new DateTime(2016, 12, 31);
            dateEdit1.Properties.CellStyleProvider = calendarControl1.CellStyleProvider = new CustomCellStyleProvider();

            ContextButton cb = new ContextButton() {
                Alignment = ContextItemAlignment.TopNear, Visibility=ContextItemVisibility.Hidden

            };
            calendarControl1.CellSize = new Size(50, 50);
            calendarControl1.ContextButtons.Add(cb);
            calendarControl1.ContextButtonCustomize += CalendarControl1_ContextButtonCustomize;
        }   

        private void CalendarControl1_ContextButtonCustomize(object sender, CalendarContextButtonCustomizeEventArgs e) {
            string holidayText;
            if (Holidays.IsHoliday(e.Cell.Date, out holidayText)) {
                e.Item.Glyph = global::Calendar_CellStyleProvider.Properties.Resources.Party;
                e.Item.Visibility = ContextItemVisibility.Visible;
                e.Item.ToolTip = holidayText;
                e.Item.ShowToolTips = true;
            }
        }
    }


    public static class Holidays {
        public static bool IsHoliday(DateTime dt, out string holidayText) {
            holidayText = "";
            //New Year's Day
            if (dt.Day == 1 && dt.Month == 1) holidayText = "New Year's Day";
            //Independence Day
            if (dt.Day == 4 && dt.Month == 7) holidayText = "Independence Day";
            //Veterans Day
            if (dt.Day == 11 && dt.Month == 11) holidayText = "Veterans Day";
            //Christmas
            if (dt.Day == 25 && dt.Month == 12) holidayText = "Christmas";
            return !string.IsNullOrEmpty(holidayText);
        }
    }

    public class CustomCellStyleProvider : ICalendarCellStyleProvider {
        static Font font;
        public void UpdateAppearance(CalendarCellStyle cell) {
            string holidayText;
            if(Holidays.IsHoliday(cell.Date, out holidayText)) {
                cell.Appearance.ForeColor = Color.Yellow;
                if(font == null) {
                    font = new Font(cell.Appearance.Font, FontStyle.Bold);
                }
                cell.Appearance.Font = font;
                if (cell.Active)
                    cell.Appearance.BackColor = Color.HotPink;
                else
                    cell.Appearance.BackColor = Color.LightPink;
            }
        }
    }
}
