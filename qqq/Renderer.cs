using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace qqq
{
    class Vertex
    {
        public int x, y;

        public Vertex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Edge
    {
        public int v1, v2;

        public Edge(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }

    class Renderer
    {
        private Graphics graphics;
        private Pen commonPen;
        private Pen activePen;
        public int vertexRadius = 15;
        private PointF point;
        private Font font;
        private Brush brush;
        private Bitmap bitmap;

        public Renderer(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            graphics = Graphics.FromImage(bitmap);

            commonPen = new Pen(Color.MediumPurple);
            commonPen.Width = 1;

            activePen = new Pen(Color.DarkGreen);
            activePen.Width = 2;
     
            font = new Font("Times New Roman", 14);
            brush = Brushes.MediumPurple;
        }

        public Bitmap graphBitmap
        {
            get
            {
                return bitmap;
            }
        }

        public void renderVertex(int x, int y, string number)
        {
            graphics.FillEllipse(Brushes.White, (x - vertexRadius), (y - vertexRadius), 2 * vertexRadius, 2 * vertexRadius);
            graphics.DrawEllipse(commonPen, (x - vertexRadius), (y - vertexRadius), 2 * vertexRadius, 2 * vertexRadius);

            point = new PointF(x - 9, y - 9);

            graphics.DrawString(number, font, brush, point);
        }

        public void renderActiveVertex(int x, int y)
        {
            graphics.DrawEllipse(activePen, (x - vertexRadius), (y - vertexRadius), 2 * vertexRadius, 2 * vertexRadius);
        }

        public void renderEdge(Vertex V1, Vertex V2, Edge E, int numberE)
        {
            if (E.v1 == E.v2)
            {
                graphics.DrawArc(commonPen, (V1.x - 2 * vertexRadius), (V1.y - 2 * vertexRadius), 2 * vertexRadius, 2 * vertexRadius, 90, 270);
                point = new PointF(V1.x - (int)(2.75 * vertexRadius), V1.y - (int)(2.75 * vertexRadius));
                renderVertex(V1.x, V1.y, (E.v1 + 1).ToString());
                return;
            }
            
            
            graphics.DrawLine(commonPen, V1.x, V1.y, V2.x, V2.y);
            point = new PointF((V1.x + V2.x) / 2, (V1.y + V2.y) / 2);
            renderVertex(V1.x, V1.y, (E.v1 + 1).ToString());
            renderVertex(V2.x, V2.y, (E.v2 + 1).ToString());
        }

        public void renderGraph(List<Vertex> V, List<Edge> E)
        {
            for (int i = 0; i < E.Count; i++)
            {
                if (E[i].v1 == E[i].v2)
                {
                    graphics.DrawArc(commonPen, (V[E[i].v1].x - 2 * vertexRadius), (V[E[i].v1].y - 2 * vertexRadius), 2 * vertexRadius, 2 * vertexRadius, 90, 270);
                    point = new PointF(V[E[i].v1].x - (int)(2.75 * vertexRadius), V[E[i].v1].y - (int)(2.75 * vertexRadius));
                    break;
                }

                 graphics.DrawLine(commonPen, V[E[i].v1].x, V[E[i].v1].y, V[E[i].v2].x, V[E[i].v2].y);
                 point = new PointF((V[E[i].v1].x + V[E[i].v2].x) / 2, (V[E[i].v1].y + V[E[i].v2].y) / 2);
                
            }

            for (int i = 0; i < V.Count; i++)
            {
                renderVertex(V[i].x, V[i].y, (i + 1).ToString());
            }
        }

        public void fillAdjacencyMatrix(int numberV, List<Edge> E, int[,] matrix)
        {
            for (int i = 0; i < numberV; i++)
                for (int j = 0; j < numberV; j++)
                    matrix[i, j] = 0;
            for (int i = 0; i < E.Count; i++)
            {
                matrix[E[i].v1, E[i].v2] = 1;
                matrix[E[i].v2, E[i].v1] = 1;
            }
        }
    }
}
