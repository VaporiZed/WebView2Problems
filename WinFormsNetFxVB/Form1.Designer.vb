<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.WebView = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.BtnVisitSampleWebsite = New System.Windows.Forms.Button()
        Me.BtnInitializeWebView = New System.Windows.Forms.Button()
        Me.BtnTryToModifyBrowserBehavior = New System.Windows.Forms.Button()
        Me.LbxModifyFails = New System.Windows.Forms.ListBox()
        CType(Me.WebView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebView
        '
        Me.WebView.AllowExternalDrop = True
        Me.WebView.BackColor = System.Drawing.Color.White
        Me.WebView.CreationProperties = Nothing
        Me.WebView.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView.Location = New System.Drawing.Point(12, 12)
        Me.WebView.Name = "WebView"
        Me.WebView.Size = New System.Drawing.Size(695, 471)
        Me.WebView.TabIndex = 0
        Me.WebView.ZoomFactor = 1.0R
        '
        'BtnVisitSampleWebsite
        '
        Me.BtnVisitSampleWebsite.Enabled = False
        Me.BtnVisitSampleWebsite.Location = New System.Drawing.Point(946, 70)
        Me.BtnVisitSampleWebsite.Name = "BtnVisitSampleWebsite"
        Me.BtnVisitSampleWebsite.Size = New System.Drawing.Size(173, 52)
        Me.BtnVisitSampleWebsite.TabIndex = 1
        Me.BtnVisitSampleWebsite.Text = "visit sample website"
        Me.BtnVisitSampleWebsite.UseVisualStyleBackColor = True
        '
        'BtnInitializeWebView
        '
        Me.BtnInitializeWebView.Location = New System.Drawing.Point(946, 12)
        Me.BtnInitializeWebView.Name = "BtnInitializeWebView"
        Me.BtnInitializeWebView.Size = New System.Drawing.Size(173, 52)
        Me.BtnInitializeWebView.TabIndex = 2
        Me.BtnInitializeWebView.Text = "initialize WebView2"
        Me.BtnInitializeWebView.UseVisualStyleBackColor = True
        '
        'BtnTryToModifyBrowserBehavior
        '
        Me.BtnTryToModifyBrowserBehavior.Enabled = False
        Me.BtnTryToModifyBrowserBehavior.Location = New System.Drawing.Point(946, 128)
        Me.BtnTryToModifyBrowserBehavior.Name = "BtnTryToModifyBrowserBehavior"
        Me.BtnTryToModifyBrowserBehavior.Size = New System.Drawing.Size(173, 52)
        Me.BtnTryToModifyBrowserBehavior.TabIndex = 3
        Me.BtnTryToModifyBrowserBehavior.Text = "try to modify browser behavior"
        Me.BtnTryToModifyBrowserBehavior.UseVisualStyleBackColor = True
        '
        'LbxModifyFails
        '
        Me.LbxModifyFails.FormattingEnabled = True
        Me.LbxModifyFails.Location = New System.Drawing.Point(713, 186)
        Me.LbxModifyFails.Name = "LbxModifyFails"
        Me.LbxModifyFails.Size = New System.Drawing.Size(406, 95)
        Me.LbxModifyFails.TabIndex = 4
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1131, 495)
        Me.Controls.Add(Me.LbxModifyFails)
        Me.Controls.Add(Me.BtnTryToModifyBrowserBehavior)
        Me.Controls.Add(Me.BtnInitializeWebView)
        Me.Controls.Add(Me.BtnVisitSampleWebsite)
        Me.Controls.Add(Me.WebView)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Hauptformular"
        CType(Me.WebView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CanBeChangedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents WebView As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents BtnVisitSampleWebsite As Button
    Friend WithEvents BtnInitializeWebView As Button
    Friend WithEvents BtnTryToModifyBrowserBehavior As Button
    Friend WithEvents LbxModifyFails As ListBox
End Class
