using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Car newCar = new Car(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text));
//textBox4.Text = newCar.Age().ToString();
namespace TextureView
{
    public class Car
    {
        int age;
        public Car(String make, String model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;

        }
        public String Make
        { get; set; }
        public String Model
        { get; set; }
        public int Year
        { get; set; }
        public int Age()
        {
            age = System.DateTime.Today.Year - Year;
            return (age);
        }
    }
}

