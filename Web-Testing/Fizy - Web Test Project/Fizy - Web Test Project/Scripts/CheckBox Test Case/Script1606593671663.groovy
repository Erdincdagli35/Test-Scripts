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

/*
 * In this test case; With the concept of "click (findTestObject (arg))",
 * we tried to test the usability of our test case by clicking on all objects by using the objects we have determined with Spy Web as arguments.
 * */
//We created an array for categories
def menuArray = ["home","accounts","help","gift","fastSignIn"]
def midMenuArray = ["premium","account"]
//We made the browser ready for testing.
WebUI.openBrowser('https://fizy.com/')
WebUI.maximizeWindow()
//FWTA_CheckBox_001
//We tested right and left arrows
for(int k=0;k<=4;k++){
	WebUI.delay(5)
	WebUI.click(findTestObject('Object Repository/fizyMenu/'+menuArray[k]))
	WebUI.delay(5)
	WebUI.navigateToUrl('https://fizy.com/')
}
//FWTA_CheckBox_002
for(int i=0;i<=1;i++){
	
	WebUI.delay(5)
	WebUI.click(findTestObject('Object Repository/midMenu/'+midMenuArray[i]))
	WebUI.delay(5)
	WebUI.navigateToUrl('https://fizy.com/')
}

WebUI.closeBrowser()
