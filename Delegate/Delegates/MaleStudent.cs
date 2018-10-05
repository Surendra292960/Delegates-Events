using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    public delegate void LinkToEventHandlers(int i);

    class MaleStudent
    {
        string name;
        int Marks;

        public MaleStudent(string nameArg, int marks)
        {
            name = nameArg;
            Marks = marks;
        }
        public void MyActionItem(int i)
        {
            if (i == 1)
                System.Console.WriteLine("{0} Got Admission. He must pay fees", name);
            else
                System.Console.WriteLine("{0} did not Get Admission. He must lookout for other college", name);
        }
        public int GetMarks()
        {
            return Marks;
        }
    }

    class FemaleStudent
    {
        string name;
        int Marks;

        public FemaleStudent(string nameArg, int marks)
        {
            name = nameArg;
            Marks = marks;
        }
        public void MyActionItem(int i)
        {
            if (i == 1)
                System.Console.WriteLine("{0} got Admission. He must pay fees", name);
            else
                System.Console.WriteLine("{0} did not Get Admission. He must lookout for other college", name);
        }
        public int GetMarks()
        {
            return Marks;
        }
    }

    class EventGeneratorClass5
    {
        public static event LinkToEventHandlers AdmissionDeniedEvt;
        public static event LinkToEventHandlers AdmissionGrantedEvt;

        public static void Main()
        {
            MaleStudent Tom = new MaleStudent("Tom", 95);
            MaleStudent Dick = new MaleStudent("Dick", 89);
            MaleStudent Harry = new MaleStudent("Harry", 91);

            FemaleStudent Shaka = new FemaleStudent("Shaka", 92);
            FemaleStudent Laka = new FemaleStudent("Laka", 88);
            FemaleStudent Baby = new FemaleStudent("Baby", 91);

            if (Tom.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandlers(Tom.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandlers(Tom.MyActionItem);

            if (Dick.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandlers(Dick.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandlers(Dick.MyActionItem);

            if (Harry.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandlers(Harry.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandlers(Harry.MyActionItem);

            if (Shaka.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandlers(Shaka.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandlers(Shaka.MyActionItem);

            if (Laka.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandlers(Laka.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandlers(Laka.MyActionItem);

            if (Baby.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandlers(Baby.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandlers(Baby.MyActionItem);

            SendEvent();
            Console.ReadLine();
        }

        public static void SendEvent()
        {
            if (AdmissionGrantedEvt != null)
            {
                AdmissionGrantedEvt(1);
            }

            if (AdmissionDeniedEvt != null)
            {
                AdmissionDeniedEvt(0);
            }
        }
    }
}
