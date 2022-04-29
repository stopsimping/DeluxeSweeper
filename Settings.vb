Module Settings
    Friend gridSize As Integer = 8
    Friend mines As Integer = 10
    Friend seconds As Integer = 60
    Friend timerEnabled As Boolean = True
    Friend theme As Color = Color.White
    Friend defaultColorIndex As Integer = 163 ' Keep the selected Index for the checkbox in memory
    Friend saveFilePath As String = Application.ExecutablePath.Replace(Application.ProductName + ".exe", "") + "save.msw"
    Friend EnablePause As Boolean = False
    Friend alwaysWin As Boolean = False
    Friend alwaysLose As Boolean = False
    Friend animationEclatax As Boolean = False
    Friend enableDeathsound As Boolean = True
End Module
