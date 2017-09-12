using System;
using System.Collections.Generic;
using Highsoft.Web.Mvc.Charts;
using DataAccess.Repository;

namespace WebPages.Dashboard.Controllers
{
    public partial class HighChartsControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            vReportExamsRepository rep = new vReportExamsRepository();
            vLessonGroupRepository lgr = new vLessonGroupRepository();

            List<decimal?> l = rep.getStudentNomreByStuCode("93125019", 0, 3);
            List<string> s = rep.getSessionDates(3);

            string year = lgr.GetLastYear();
            int classCount = lgr.GetCountOfClassesOfGrade(6, year);
            List<List<decimal>> datalist = new List<List<decimal>>();

            List<LineSeriesData> studentData = new List<LineSeriesData>();

            l.ForEach(p => studentData.Add(new LineSeriesData { Y = (double)p }));

            Highcharts higcharts = new Highcharts
            {
                Title = new Title
                {
                    Text = "Monthly Average Temperature",
                    X = -20
                },
                Subtitle = new Subtitle
                {
                    Text = "Source: WorldClimate.com",
                    X = -20
                },
                XAxis = new List<XAxis>
                {
                new XAxis
                {
                    Categories = s
                }
            },
                YAxis = new List<YAxis>
                {
                new YAxis
                {
                    Title = new YAxisTitle
                    {
                        Text = "Temperature (°C)"
                    },
                    PlotLines = new List<YAxisPlotLines>                    {
                        new YAxisPlotLines
                        {
                            Value = 0,
                            Width = 1,
                            Color = "#808080"
                        }
                    }
                }
            },
                Tooltip = new Tooltip
                {
                    ValueSuffix = "°C"
                },
                Legend = new Legend
                {
                    Layout = LegendLayout.Vertical,
                    Align = LegendAlign.Right,
                    VerticalAlign = LegendVerticalAlign.Middle,
                    BorderWidth = 0
                },
                Series = new List<Series>
                {
                new LineSeries
                {
                    Name = "student",
                    Data = studentData
                }
            }
            };

            Title t = new Title();
            t.Text = "Monthly Average Temperature";
            t.X = -20;
            higcharts.Title = t;

            Subtitle sub = new Subtitle();
            sub.Text = "Source: WorldClimate.com";
            sub.X = -20;
            HighsoftNamespace Highsoft = new HighsoftNamespace();

            //string result = Highsoft.Highcharts(higcharts, "chart").ToHtmlString(); //For version 5.0.6326 or older
            string result = Highsoft.GetHighcharts(higcharts, "chart").ToHtmlString(); //For version 5.0.6327 or newer

            Response.Write(result);
        }
    }
}