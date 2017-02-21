using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace VectonSensingDemo2
{
    public partial class Form1 : Form
    {
        Thread m_thread;
        bool m_running = false;
        ManualResetEvent m_event = new ManualResetEvent(true);
        bool m_pause = false;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            CreateZedGraph();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            if (m_thread == null || m_thread.IsAlive == false)
            {
                ClearGraph();
                m_thread = new Thread(Process);
                m_thread.Start();
            }
        }
        void Process()
        {
            Random random = new Random();
            int index = 0;
            PointPair point = new PointPair();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            m_running = true;
            while (m_running == true)
            {
                m_event.WaitOne();
                point.Y = random.Next(0, 1000);
                point.X++;
                DrawPoint(zed1, index, point);
                ssData.Value = point.Y.ToString();
                RefresheZedGraphs(zed1);
                Thread.Sleep(700);                
            }
            btnStart.Enabled = true;
        }
        private void CreateZedGraph()
        {
            Random rand = new Random();
            PointPairList spl3 = new PointPairList();
            Color c1 = Color.FromArgb(255, rand.Next(255), rand.Next(255), rand.Next(255));
            zed1.GraphPane.AddCurve("Demo", spl3, c1, SymbolType.None);
        }
        void ClearGraph()
        {

            zed1.GraphPane.CurveList[0].Clear();           
         
            RefresheZedGraphs(zed1);
           
        }
        private void DrawPoint(ZedGraph.ZedGraphControl zgc, int index, PointPair p)
        {
            zgc.GraphPane.CurveList[index].AddPoint(p);
        }
        
        private void RefresheZedGraphs(ZedGraph.ZedGraphControl zg)
        {
            zg.AxisChange();
            zg.Invalidate();
            //zg.Refresh();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            m_running = false;
            m_event.Set();
            if (m_thread == null)
                m_thread.Join();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (m_pause == false)
            {
                m_event.Reset();
            }
            else
            {
                m_event.Set();
            }
            m_pause = !m_pause;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_event.Set();
            m_running = false;
            if (m_thread != null)
                m_thread.Join();
            Close();
        }
    }
}
