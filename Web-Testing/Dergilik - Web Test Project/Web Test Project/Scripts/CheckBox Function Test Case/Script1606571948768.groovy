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
def myArray = ["cocuk","anneveebebek","yemek","sporveVcutGelistirme","egitim","fotografclk","dekorasyon","kataloglar","magazin",
				"moda","otomotiv","oyun","saglk","teknoloji","yasam","yabancDergiler","kulturveSanat","kamu","mizah","erkek","bilim","kadn","isDunyasi"] 
def midMenuArray = ["left","right"]
//WTA_Checkbox_001
//We made the browser ready for testing.
WebUI.openBrowser('https://dergilik.com.tr/')
WebUI.verifyMatch(WebUI.getWindowTitle(), 'Dergilik', false)
WebUI.maximizeWindow()
WebUI.delay(5)
//WTA_Checkbox_002
//We tested right and left arrows
for(int k=0;k<2;k++){
	WebUI.delay(5)
	WebUI.click(findTestObject('Object Repository/midMenu/'+midMenuArray[k]))
	WebUI.delay(5)
}
//WTA_Checkbox_003
//We redirected to the category tab.
WebUI.delay(3)
WebUI.click(findTestObject('Object Repository/Page_Dergilik/a_KATEGOR'))
WebUI.delay(5)
//WTA_Checkbox_004
//We tested sub-categories 
for(int i=0;i<=22;i++){
	
	WebUI.delay(5)
	WebUI.click(findTestObject('Object Repository/Page_Dergilik/'+myArray[i]))
	WebUI.delay(5)
	WebUI.navigateToUrl('https://dergilik.com.tr/category')
}
//WTA_Checkbox_005
//We returned home page
WebUI.navigateToUrl('https://dergilik.com.tr/')
WebUI.verifyMatch(WebUI.getWindowTitle(), 'Dergilik', false)

//WTA_Checkbox_006
//We redirected to SSS
WebUI.delay(5)
WebUI.click(findTestObject('Object Repository/Page_Dergilik/a_S.S.S'))
WebUI.delay(10)

//WTA_Checkbox_007
WebUI.navigateToUrl('https://dergilik.com.tr/')
WebUI.verifyMatch(WebUI.getWindowTitle(), 'Dergilik', false)
WebUI.delay(10)

//WTA_Checkbox_008
//We redirected to fast sign in
WebUI.click(findTestObject('Object Repository/rightMenu/hzlGiri'))
WebUI.verifyMatch(WebUI.getWindowTitle(), 'Dergilik', false)
WebUI.delay(10)
//WTA_Checkbox_009
WebUI.click(findTestObject('Object Repository/rightMenu/a_English'))
WebUI.refresh()

WebUI.closeBrowser()
