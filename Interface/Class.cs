using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IData
    {
        public void PrintDeviceInfo();
        public void Media_type_size();
        public void Copy();
        public void Free_Memory();
    }
    public abstract class Storage
    {
        private string medianin_adi;
        public string Medianin_adi
        {
            get { return medianin_adi; }
            set { medianin_adi = value; }
        }


        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        } 
    }


    public class Flash : Storage, IData
    {

        private float speed_usb_3_0;    
        public float Speed_Usb_3_0
        {
            get { return speed_usb_3_0; }
            set { speed_usb_3_0 = value; }
        }

        private float  memory;
        public float  Memory
        {
            get { return memory; }
            set { memory = value; }
        }

        public void Copy()
        {
            Console.WriteLine("Flash Drive Copy() Method");
        }

        public void Free_Memory()
        {
            Console.WriteLine("Flash Drive Free_Memory() Method");

        }

        public void Media_type_size()
        {
            Console.WriteLine("Flash Drive Media_Type_Size() Method");
        }

        public void PrintDeviceInfo()
        {
            Console.WriteLine("Flash Drive PrintDeviceInfo Method");
        }
    }


    public class DVD : Storage, IData
    {

        private float read_speed;
        public float Read_Speed
        {
            get { return read_speed; }
            set { read_speed = value; }
        }

        private float write_Speed;

        public float Write_Speed
        {
            get { return write_Speed; }
            set { write_Speed = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        public void Copy()
        {
            Console.WriteLine("DvD Copy() Method");
        }

        public void Free_Memory()
        {
            Console.WriteLine("DvD Free_Memory() Method");

        }

        public void Media_type_size()
        {
            Console.WriteLine("DvD Media_Type_Size() Method");
        }

        public void PrintDeviceInfo()
        {
            Console.WriteLine("DvD PrintDeviceInfo Method");
        }
    }

    public class HDD : Storage, IData
    {

        private float speed_usb_2_0;    
        public float Speed_Usb_2_0
        {
            get { return speed_usb_2_0; }
            set { speed_usb_2_0 = value; }
        }


        private float size;
        public float Size
        {
            get { return size; }
            set { size = value; }
        }



        public void Copy()
        {
            Console.WriteLine("HDD Copy() Method");
        }

        public void Free_Memory()
        {
            Console.WriteLine("HDD Free_Memory() Method");

        }

        public void Media_type_size()
        {
            Console.WriteLine("HDD Media_Type_Size() Method");
        }

        public void PrintDeviceInfo()
        {
            Console.WriteLine("HDD PrintDeviceInfo Method");
        }
    }
}
//ByVC