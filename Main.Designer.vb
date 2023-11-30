<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.LanguageSelect = New System.Windows.Forms.ComboBox()
        Me.Lang = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LanguageSelect
        '
        Me.LanguageSelect.FormattingEnabled = True
        Me.LanguageSelect.Items.AddRange(New Object() {resources.GetString("LanguageSelect.Items"), resources.GetString("LanguageSelect.Items1"), resources.GetString("LanguageSelect.Items2")})
        resources.ApplyResources(Me.LanguageSelect, "LanguageSelect")
        Me.LanguageSelect.Name = "LanguageSelect"
        '
        'Lang
        '
        resources.ApplyResources(Me.Lang, "Lang")
        Me.Lang.Name = "Lang"
        '
        'Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Lang)
        Me.Controls.Add(Me.LanguageSelect)
        Me.Name = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LanguageSelect As ComboBox
    Friend WithEvents Lang As Label
End Class
