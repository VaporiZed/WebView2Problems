Friend Class Form1
	Private Async Sub BtnInitializeWebView_Click(sender As Object, e As EventArgs) Handles BtnInitializeWebView.Click
		Await WebView.EnsureCoreWebView2Async
		WebView.CoreWebView2.Settings.HiddenPdfToolbarItems = Microsoft.Web.WebView2.Core.CoreWebView2PdfToolbarItems.None
		BtnVisitSampleWebsite.Enabled = True
		BtnTryToModifyBrowserBehavior.Enabled = True
	End Sub

	Private Sub BtnVisitSampleWebsite_Click(sender As Object, e As EventArgs) Handles BtnVisitSampleWebsite.Click
		WebView.CoreWebView2.Navigate("https://de.wikipedia.org/wiki/Datei:Test.pdf")
	End Sub

	Private Async Sub BtnTryToModifyBrowserBehavior_Click(sender As Object, e As EventArgs) Handles BtnTryToModifyBrowserBehavior.Click
		Try
			Await WebView.CoreWebView2.CallDevToolsProtocolMethodAsync("Browser.setDownloadBehavior", "{behavior: deny}")
			LbxModifyFails.Items.Add("method 1 succeeded")
		Catch ex As Exception
			LbxModifyFails.Items.Add("method 1 failed: " & ex.Message)
		End Try

		Try
			Await WebView.CoreWebView2.CallDevToolsProtocolMethodAsync("Browser.setDownloadBehavior", "{behavior: 'deny'}")
			LbxModifyFails.Items.Add("method 2 succeeded")
		Catch ex As Exception
			LbxModifyFails.Items.Add("method 2 failed: " & ex.Message)
		End Try

		Try
			Await WebView.CoreWebView2.CallDevToolsProtocolMethodAsync("Browser.setDownloadBehavior", "{'behavior': 'deny'}")
			LbxModifyFails.Items.Add("method 3 succeeded")
		Catch ex As Exception
			LbxModifyFails.Items.Add("method 3 failed: " & ex.Message)
		End Try

		Try
			Await WebView.CoreWebView2.CallDevToolsProtocolMethodAsync("Browser.setDownloadBehavior", "{behavior: ""deny""}")
			LbxModifyFails.Items.Add("method 4 succeeded")
		Catch ex As Exception
			LbxModifyFails.Items.Add("method 4 failed: " & ex.Message)
		End Try

		Try
			Await WebView.CoreWebView2.CallDevToolsProtocolMethodAsync("Browser.setDownloadBehavior", "{""behavior"": ""deny""}")
			LbxModifyFails.Items.Add("method 5 succeeded")
		Catch ex As Exception
			LbxModifyFails.Items.Add("method 5 failed: " & ex.Message)
		End Try

		Try
			Await WebView.CoreWebView2.CallDevToolsProtocolMethodAsync("Browser.setDownloadBehavior", "{behavior: """"deny""""}")
			LbxModifyFails.Items.Add("method 6 succeeded")
		Catch ex As Exception
			LbxModifyFails.Items.Add("method 6 failed: " & ex.Message)
		End Try

		Try
			Await WebView.CoreWebView2.CallDevToolsProtocolMethodAsync("Browser.setDownloadBehavior", "{'behavior': """"deny""""}")
			LbxModifyFails.Items.Add("method 7 succeeded")
		Catch ex As Exception
			LbxModifyFails.Items.Add("method 7 failed: " & ex.Message)
		End Try

		Try
			Await WebView.CoreWebView2.CallDevToolsProtocolMethodAsync("Browser.setDownloadBehavior", "{""behavior"": """"deny""""}")
			LbxModifyFails.Items.Add("method 8 succeeded")
		Catch ex As Exception
			LbxModifyFails.Items.Add("method 8 failed: " & ex.Message)
		End Try

		Try
			Await WebView.CoreWebView2.CallDevToolsProtocolMethodAsync("Browser.setDownloadBehavior", "{""""behavior"""": """"deny""""}")
			LbxModifyFails.Items.Add("method 9 succeeded")
		Catch ex As Exception
			LbxModifyFails.Items.Add("method 9 failed: " & ex.Message)
		End Try

	End Sub
End Class