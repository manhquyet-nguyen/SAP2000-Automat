Public Class AnalysisOptionsForm

    Private options As AnalysisOptions

    Public Sub New(ByRef options As AnalysisOptions)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.options = options
    End Sub


    Private Sub AnalysisOptionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bindCombobox(cbSolverType, GetType(SolverType))

        bindCombobox(cbSolverProcessType, GetType(SolverProcessType))

        refreshForm()
    End Sub

    Private Sub refreshForm()
        cbSolverType.SelectedValue = options.solverType
        cbSolverProcessType.SelectedValue = options.solverProcessType
        txtInstanceCount.Text = options.instancesCount
    End Sub

    Private Sub bindCombobox(cb As ComboBox, enumType As Type)
        cb.DataSource = EnumUtil.enumsAsMap(enumType).ToList
        cb.DisplayMember = "Key"
        cb.ValueMember = "Value"
    End Sub

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        options.solverType = MainForm.DEFAULT_ANALYSIS_OPTIONS.solverType
        options.solverProcessType = MainForm.DEFAULT_ANALYSIS_OPTIONS.solverProcessType
        options.instancesCount = MainForm.DEFAULT_ANALYSIS_OPTIONS.instancesCount
        options.force32Bit = MainForm.DEFAULT_ANALYSIS_OPTIONS.force32Bit
        options.stiffPath = MainForm.DEFAULT_ANALYSIS_OPTIONS.stiffPath
        refreshForm()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim instancesCount As Integer
        Try
            instancesCount = txtInstanceCount.Text
        Catch ex As Exception
            MessageBox.Show("Must input concurrency level as an integer in [1, 20]")
            Return
        End Try
        If (instancesCount < 1 Or instancesCount > 20) Then
            MessageBox.Show("Must input concurrency level as an integer in [1, 20]")
            Return
        End If

        options.solverType = cbSolverType.SelectedValue
        options.solverProcessType = cbSolverProcessType.SelectedValue
        options.instancesCount = instancesCount
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class