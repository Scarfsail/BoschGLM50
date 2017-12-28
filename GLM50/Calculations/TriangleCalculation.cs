using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLM50.Calculations
{
    public partial class TriangleCalculation : Form, ICalculationDialog
    {
        private struct Triangle
        {
            public float? sideA;
            public float? sideB;
            public float? sideC;
            public double? angleA;
            public double? angleB;
            public double? angleC;
        }

        private Triangle triangle;
        public TriangleCalculation()
        {
            InitializeComponent();
            triangle = new Triangle();

            this.CalculateTriangle();
            this.RenderTriangle();

        }

        public void MeasurementReceived(float value)
        {
            if (!triangle.sideA.HasValue)
            {
                triangle.sideA = value;
                this.RenderTriangle();
                return;
            }
            if (!triangle.sideB.HasValue)
            {
                triangle.sideB = value;
                this.RenderTriangle();
                return;
            }
            if (!triangle.sideC.HasValue)
            {
                triangle.sideC = value;
                this.RenderTriangle();
            }
            if (!triangle.angleA.HasValue)
            {
                this.CalculateTriangle();
                this.RenderTriangle();
            }
        }

        private void CalculateTriangle()
        {

            var t = triangle;
            if (!t.sideA.HasValue || !t.sideB.HasValue || !t.sideC.HasValue)
                return;

            t.angleA = Math.Acos((Math.Pow(t.sideB.Value, 2) + Math.Pow(t.sideC.Value, 2) - Math.Pow(t.sideA.Value, 2)) / (2 * t.sideB.Value * t.sideC.Value));
            t.angleB = Math.Asin((t.sideB.Value * Math.Sin(t.angleA.Value)) / t.sideA.Value);
            t.angleA = t.angleA * 180 / Math.PI;
            t.angleB = t.angleB * 180 / Math.PI;
            t.angleC = 180 - (t.angleA.Value + t.angleB.Value);
            triangle = t;

        }

        private void RenderTriangle()
        {
            var t = triangle;

            this.RenderText(this.sideA, t.sideA, "a", "m");
            this.RenderText(this.sideB, t.sideB, "b", "m");
            this.RenderText(this.sideC, t.sideC, "c", "m");

            this.RenderText(this.angleA, t.angleA, "α", "°");
            this.RenderText(this.angleB, t.angleB, "β", "°");
            this.RenderText(this.angleC, t.angleC, "ᵞ", "°");

            if (t.angleA.HasValue && t.angleB.HasValue && t.angleC.HasValue)
            {
                this.angleA.Font = new Font(this.angleA.Font, t.angleA.Value > t.angleB.Value && t.angleA.Value > t.angleC.Value ? FontStyle.Bold : FontStyle.Regular);
                this.angleB.Font = new Font(this.angleB.Font, t.angleB.Value > t.angleA.Value && t.angleB.Value > t.angleC.Value ? FontStyle.Bold : FontStyle.Regular);
                this.angleC.Font = new Font(this.angleC.Font, t.angleC.Value > t.angleA.Value && t.angleC.Value > t.angleB.Value ? FontStyle.Bold : FontStyle.Regular);
            }
        }

        private void RenderText(Label label, double? number, string title, string units)
        {
            string result = title + " = ";

            if (!number.HasValue)
                result += "?";
            else
            {
                result += Math.Round(number.Value, 2).ToString() + " " + units;
            }

            label.Text = result;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.triangle = new Triangle();
            this.CalculateTriangle();
            this.RenderTriangle();
        }
    }
}
