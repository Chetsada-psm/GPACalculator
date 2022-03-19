using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator;

internal class GPACalculator
{
    private double sum = 0;
    private int n = 0;
    private double max = 0;
    private double min = 0;
    private string name = string.Empty; // ""
    private string alldata = string.Empty;

    internal void addGPA(double dInput, string name, object nameMin)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Add new GPA to class
    /// </summary>
    /// <param name="gpa">gpa score</param>
    public void addGPA(double gpa, string name)
    {
        sum += gpa;
        n++;
        this.alldata += name + " " + gpa + "\r\n";

        if (max < gpa)
        {

            max = gpa;
            this.name = name;
        }

        if (min > gpa)
        {
            min = gpa;
        }

    }
    /// <summary>
    /// Return GPAx of class 
    /// </summary>
    /// <returns>GPAx</returns>
    public double getGPAx()
    {
        double result = sum / n;
        return result;
    }
    public double getMax()
    {
        return max;
    }
    public string getMaxName()
    {
        return name;
    }

    public double getMin()
    {
        return min;
    }

    public string getMinName()
    {
        return name;
    }

    public string getAlldata()
    {
        return alldata;
    }

}
