using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gpax
{
    internal class GPACalculator
    {
        private double gpa_sum;
        private int n;
        private List<double> gpaList; // เพิ่มการเก็บ GPA ทั้งหมด
        private int totalPeople; // เก็บจำนวนคน

        public GPACalculator()
        {
            gpaList = new List<double>(); // สร้าง List ใหม่เมื่อมีการสร้างอ็อบเจ็กต์
            totalPeople = 0; // เริ่มต้นที่ 0
        }

        // เพิ่ม GPA ลงใน List และคำนวณค่าเฉลี่ย
        public void setGPA(double gpa)
        {
            this.gpaList.Add(gpa);  // เก็บ GPA
            this.gpa_sum += gpa;
            this.n++;
            this.totalPeople++;
        }

        // คำนวณ GPA เฉลี่ย
        public double getGPAX()
        {
            return this.n == 0 ? 0 : this.gpa_sum / this.n; // ป้องกันการหารด้วยศูนย์
        }

        // คำนวณ GPA สูงสุด
        public double getMaxGPA()
        {
            if (gpaList.Count == 0)
                return 0; // ถ้ายังไม่มี GPA ใน List ก็จะคืนค่า 0
            return gpaList.Max(); // ใช้ฟังก์ชัน Max() จาก Linq
        }

        // คำนวณ GPA ต่ำสุด
        public double getMinGPA()
        {
            if (gpaList.Count == 0)
                return 0; // ถ้ายังไม่มี GPA ใน List ก็จะคืนค่า 0
            return gpaList.Min(); // ใช้ฟังก์ชัน Min() จาก Linq
        }
        public int getTotalPeople()
        {
            return totalPeople;
        }
    }
}

