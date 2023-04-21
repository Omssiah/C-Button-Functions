CLOSE BUTTON: 

Application.Exit();

---------------------

MINIMIZE BUTTON:

WindowState = FormWindowState.Minimized;

---------------------
OPEN FILE:


OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
            }
