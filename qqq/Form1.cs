using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qqq
{
    public partial class Form1 : Form
    {
        private Renderer renderer;
        private List<Vertex> vertextList;
        private List<Edge> edgeList;
        private int[,] adjacencyMatrix;

        private int selectedEdge1;
        private int selectedEdge2;

        public Form1()
        {
            InitializeComponent();

            renderer = new Renderer(graphContainer.Width, graphContainer.Height);
            graphContainer.Image = renderer.graphBitmap;

            vertextList = new List<Vertex>();
            edgeList = new List<Edge>();
        }

        private void vertexCreateButton_Click(object sender, EventArgs e)
        {
            vertexCreateButton.Enabled = false;
            vertexConnectButton.Enabled = true;

            renderer.renderGraph(vertextList, edgeList);
            graphContainer.Image = renderer.graphBitmap;
        }

        private void vertexConnectButton_Click(object sender, EventArgs e)
        {
            vertexConnectButton.Enabled = false;
            vertexCreateButton.Enabled = true;

            renderer.renderGraph(vertextList, edgeList);
            graphContainer.Image = renderer.graphBitmap;

            selectedEdge1 = -1;
            selectedEdge2 = -1;
        }

        private void graphContainer_MouseClick(object sender, MouseEventArgs e)
        {
            if (!vertexCreateButton.Enabled)
            {
                vertextList.Add(new Vertex(e.X, e.Y));
                renderer.renderVertex(e.X, e.Y, vertextList.Count.ToString());
                graphContainer.Image = renderer.graphBitmap;

                return;
            }

            if (!vertexConnectButton.Enabled)
            {
                for (int i = 0; i < vertextList.Count; i++)
                {
                    if (Math.Pow((vertextList[i].x - e.X), 2) + Math.Pow((vertextList[i].y - e.Y), 2) <= renderer.vertexRadius * renderer.vertexRadius)
                    {
                        if (selectedEdge1 == -1)
                        {
                            renderer.renderActiveVertex(vertextList[i].x, vertextList[i].y);
                            selectedEdge1 = i;
                            graphContainer.Image = renderer.graphBitmap;
                            break;
                        }

                        if (selectedEdge2 == -1)
                        {
                            renderer.renderActiveVertex(vertextList[i].x, vertextList[i].y);
                            selectedEdge2 = i;
                            edgeList.Add(new Edge(selectedEdge1, selectedEdge2));
                            renderer.renderEdge(vertextList[selectedEdge1], vertextList[selectedEdge2], edgeList[edgeList.Count - 1], edgeList.Count - 1);
                            selectedEdge1 = -1;
                            selectedEdge2 = -1;
                            graphContainer.Image = renderer.graphBitmap;
                            break;
                        }
                    }
                }
            }
        }

        private void buildMatrixButton_Click(object sender, EventArgs e)
        {
            adjacencyMatrix = new int[vertextList.Count, vertextList.Count];
            renderer.fillAdjacencyMatrix(vertextList.Count, edgeList, adjacencyMatrix);

            matrixContainer.Items.Clear();
            string sOut = "    ";

            for (int i = 0; i < vertextList.Count; i++)
                sOut += (i + 1) + " ";

            matrixContainer.Items.Add(sOut);

            for (int i = 0; i < vertextList.Count; i++)
            {
                sOut = (i + 1) + " | ";
                for (int j = 0; j < vertextList.Count; j++)
                    sOut += adjacencyMatrix[i, j] + " ";
                matrixContainer.Items.Add(sOut);
            }
        }

        private void buildPairedDisjunctsButton_Click(object sender, EventArgs e)
        {
            adjacencyMatrix = new int[vertextList.Count, vertextList.Count];
            renderer.fillAdjacencyMatrix(vertextList.Count, edgeList, adjacencyMatrix);
            pairedDisjunctsContainer.Items.Clear();
            string sOut;
            for (int i = 0; i < vertextList.Count; i++)
            {
                for (int j = i + 1; j < vertextList.Count; j++)
                {

                    if (adjacencyMatrix[i, j] == 1)
                    {
                        sOut = "[" + (i + 1) + "]" + "V" + "[" + (j + 1) + "]";
                        pairedDisjunctsContainer.Items.Add(sOut);
                    }
                }
            }
        }

        private void buildDNFButton_Click(object sender, EventArgs e)
        {
            adjacencyMatrix = new int[vertextList.Count, vertextList.Count];
            renderer.fillAdjacencyMatrix(vertextList.Count, edgeList, adjacencyMatrix);

            List<string> dnf = new List<string>();
            List<string> variable;
            DNFContainer.Items.Clear();

            for (int i = 0; i < vertextList.Count; i++)
            {
                variable = new List<string>();
                for (int j = 0; j < vertextList.Count; j++)
                {
                    variable.Add((adjacencyMatrix[i, j] == 0 ? "!" : "") + (j + 1).ToString());
                }
                if (variable.Count > 0) dnf.Add("(" + string.Join("&", variable) + ")");
            }

            DNFContainer.Items.Add(string.Join("|", dnf));
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            adjacencyMatrix = new int[vertextList.Count, vertextList.Count];
            renderer.fillAdjacencyMatrix(vertextList.Count, edgeList, adjacencyMatrix);
            List<string> dnf = new List<string>();
            resultContainer.Items.Clear();
            int max = 0;
            List<string> result = new List<string>();
            for (int i = 0; i < vertextList.Count; i++)
            {
                List<string> temp = new List<string>();
                int count = 0;
                for (int j = 0; j < vertextList.Count; j++)
                {
                    if (adjacencyMatrix[i, j] == 1)
                    {
                        count++;
                        temp.Add((j + 1).ToString() + ',');
                    }
                }

                if (count > max)
                {
                    result.Clear();
                    result.AddRange(temp);
                    max = count;
                }
            }

            resultContainer.Items.Add(string.Join("", result));
        }
    }
}
