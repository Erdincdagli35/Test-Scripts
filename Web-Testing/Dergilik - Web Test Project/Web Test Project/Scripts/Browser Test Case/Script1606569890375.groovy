import static com.kms.katalon.core.checkpoint.CheckpointFactory.findCheckpoint
import static com.kms.katalon.core.testcase.TestCaseFactory.findTestCase
import static com.kms.katalon.core.testdata.TestDataFactory.findTestData
import static com.kms.katalon.core.testobject.ObjectRepository.findTestObject
import static com.kms.katalon.core.testobject.ObjectRepository.findWindowsObject
import com.kms.katalon.core.checkpoint.Checkpoint as Checkpoint
import com.kms.katalon.core.cucumber.keyword.CucumberBuiltinKeywords as CucumberKW
import com.kms.katalon.core.mobile.keyword.MobileBuiltInKeywords as Mobile
import com.kms.katalon.core.model.FailureHandling as FailureHandling
import com.kms.katalon.core.testcase.TestCase as TestCase
import com.kms.katalon.core.testdata.TestData as TestData
import com.kms.katalon.core.testobject.TestObject as TestObject
import com.kms.katalon.core.webservice.keyword.WSBuiltInKeywords as WS
import com.kms.katalon.core.webui.keyword.WebUiBuiltInKeywords as WebUI
import com.kms.katalon.core.windows.keyword.WindowsBuiltinKeywords as Windows
import internal.GlobalVariable as GlobalVariable
import org.openqa.selenium.Keys as Keys

/*
 * In this test case; Concepts such as "refresh", "delay" have not been studied. 
 * It has been determined that 3 different sites can redirect between each other and thanks to these concepts, basic browser operations work successfully.
 * In addition to these, it has been ensured that the sites are routed correctly with "verifyMatch".
 * */

//We made the browser ready for testing.
WebUI.openBrowser('https://dergilik.com.tr/')
WebUI.maximizeWindow()

//WTA_Browser_001
//We applied concepts of verifyMatch ,refresh, delay for first site 
WebUI.verifyMatch(WebUI.getWindowTitle(), 'Dergilik', false)
WebUI.refresh()
WebUI.delay(5)

//WTA_Browser_002
//We applied concepts of verifyMatch ,refresh, delay for second site
WebUI.navigateToUrl('https://www.turkcell.com.tr/kurumsal/kurumsal-cozumler/turkcell-filiz')
WebUI.verifyMatch(WebUI.getWindowTitle(), 'Turkcell Filiz', false)
WebUI.refresh()
WebUI.delay(7)

//WTA_Browser_003
//We applied concepts of verifyMatch ,refresh, delay for third site
WebUI.navigateToUrl('https://www.turkcell.com.tr/servisler/BiP')
WebUI.verifyMatch(WebUI.getWindowTitle(), 'Görüntülü Sohbet ve Anında Mesajlaşma : Turkcell BİP', false)
WebUI.refresh()
WebUI.delay(7)

//WTA_Browser_004
//Finally, we went back to our first site and finished our test.
WebUI.navigateToUrl('https://dergilik.com.tr/')
WebUI.verifyMatch(WebUI.getWindowTitle(), 'Dergilik', false)
WebUI.refresh()

WebUI.closeBrowser()

