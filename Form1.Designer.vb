<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.radCheese = New System.Windows.Forms.RadioButton()
        Me.radPinwheel = New System.Windows.Forms.RadioButton()
        Me.radVeggie = New System.Windows.Forms.RadioButton()
        Me.radSausage = New System.Windows.Forms.RadioButton()
        Me.radFruit = New System.Windows.Forms.RadioButton()
        Me.radPre = New System.Windows.Forms.RadioButton()
        Me.radPickup = New System.Windows.Forms.RadioButton()
        Me.FoodPrices = New System.Windows.Forms.GroupBox()
        Me.PaymentOptions = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FoodPrices.SuspendLayout()
        Me.PaymentOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(332, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(475, 252)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Catering" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Star Market" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(401, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Loyalty Points:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(627, 278)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(101, 22)
        Me.TextBox1.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(398, 338)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(137, 40)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(627, 338)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(137, 40)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 389)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Please Pay:"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(192, 389)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(0, 17)
        Me.lblPayment.TabIndex = 14
        '
        'radCheese
        '
        Me.radCheese.AutoSize = True
        Me.radCheese.Checked = True
        Me.radCheese.Location = New System.Drawing.Point(0, 19)
        Me.radCheese.Name = "radCheese"
        Me.radCheese.Size = New System.Drawing.Size(184, 21)
        Me.radCheese.TabIndex = 15
        Me.radCheese.TabStop = True
        Me.radCheese.Text = "Gourmet Cheese $49.99"
        Me.radCheese.UseVisualStyleBackColor = True
        '
        'radPinwheel
        '
        Me.radPinwheel.AutoSize = True
        Me.radPinwheel.Location = New System.Drawing.Point(0, 46)
        Me.radPinwheel.Name = "radPinwheel"
        Me.radPinwheel.Size = New System.Drawing.Size(178, 21)
        Me.radPinwheel.TabIndex = 16
        Me.radPinwheel.Text = "Pinwheel Wraps $59.99"
        Me.radPinwheel.UseVisualStyleBackColor = True
        '
        'radVeggie
        '
        Me.radVeggie.AutoSize = True
        Me.radVeggie.Location = New System.Drawing.Point(0, 73)
        Me.radVeggie.Name = "radVeggie"
        Me.radVeggie.Size = New System.Drawing.Size(121, 21)
        Me.radVeggie.TabIndex = 17
        Me.radVeggie.Text = "Veggie $29.99"
        Me.radVeggie.UseVisualStyleBackColor = True
        '
        'radSausage
        '
        Me.radSausage.AutoSize = True
        Me.radSausage.Location = New System.Drawing.Point(0, 100)
        Me.radSausage.Name = "radSausage"
        Me.radSausage.Size = New System.Drawing.Size(213, 21)
        Me.radSausage.TabIndex = 18
        Me.radSausage.Text = "Sausage and Cheese $49.99"
        Me.radSausage.UseVisualStyleBackColor = True
        '
        'radFruit
        '
        Me.radFruit.AutoSize = True
        Me.radFruit.Location = New System.Drawing.Point(0, 127)
        Me.radFruit.Name = "radFruit"
        Me.radFruit.Size = New System.Drawing.Size(105, 21)
        Me.radFruit.TabIndex = 19
        Me.radFruit.Text = "Fruit $29.99"
        Me.radFruit.UseVisualStyleBackColor = True
        '
        'radPre
        '
        Me.radPre.AutoSize = True
        Me.radPre.Checked = True
        Me.radPre.Location = New System.Drawing.Point(12, 8)
        Me.radPre.Name = "radPre"
        Me.radPre.Size = New System.Drawing.Size(79, 21)
        Me.radPre.TabIndex = 20
        Me.radPre.TabStop = True
        Me.radPre.Text = "Pre-pay"
        Me.radPre.UseVisualStyleBackColor = True
        '
        'radPickup
        '
        Me.radPickup.AutoSize = True
        Me.radPickup.Location = New System.Drawing.Point(12, 35)
        Me.radPickup.Name = "radPickup"
        Me.radPickup.Size = New System.Drawing.Size(71, 21)
        Me.radPickup.TabIndex = 21
        Me.radPickup.TabStop = True
        Me.radPickup.Text = "Pickup"
        Me.radPickup.UseVisualStyleBackColor = True
        '
        'FoodPrices
        '
        Me.FoodPrices.BackColor = System.Drawing.SystemColors.Info
        Me.FoodPrices.Controls.Add(Me.radFruit)
        Me.FoodPrices.Controls.Add(Me.radSausage)
        Me.FoodPrices.Controls.Add(Me.radVeggie)
        Me.FoodPrices.Controls.Add(Me.radPinwheel)
        Me.FoodPrices.Controls.Add(Me.radCheese)
        Me.FoodPrices.Location = New System.Drawing.Point(4, 63)
        Me.FoodPrices.Name = "FoodPrices"
        Me.FoodPrices.Size = New System.Drawing.Size(256, 167)
        Me.FoodPrices.TabIndex = 22
        Me.FoodPrices.TabStop = False
        '
        'PaymentOptions
        '
        Me.PaymentOptions.BackColor = System.Drawing.SystemColors.Info
        Me.PaymentOptions.Controls.Add(Me.radPickup)
        Me.PaymentOptions.Controls.Add(Me.radPre)
        Me.PaymentOptions.Location = New System.Drawing.Point(4, 266)
        Me.PaymentOptions.Name = "PaymentOptions"
        Me.PaymentOptions.Size = New System.Drawing.Size(264, 72)
        Me.PaymentOptions.TabIndex = 23
        Me.PaymentOptions.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PaymentOptions)
        Me.Controls.Add(Me.FoodPrices)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Catering"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FoodPrices.ResumeLayout(False)
        Me.FoodPrices.PerformLayout()
        Me.PaymentOptions.ResumeLayout(False)
        Me.PaymentOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents radCheese As RadioButton
    Friend WithEvents radPinwheel As RadioButton
    Friend WithEvents radVeggie As RadioButton
    Friend WithEvents radSausage As RadioButton
    Friend WithEvents radFruit As RadioButton
    Friend WithEvents radPre As RadioButton
    Friend WithEvents radPickup As RadioButton
    Friend WithEvents FoodPrices As GroupBox
    Friend WithEvents PaymentOptions As GroupBox
End Class
