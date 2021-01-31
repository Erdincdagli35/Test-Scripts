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
 * In this test case; It is aimed to successfully test the usability of a simple form requested from the user. 
 * In this form, integer and string data types were tested on two textboxes to check their operability. 
 * As a result, the first textbox can receive only interger values without any problem, while the other textbox, the verification code, can receive lowercase letters from the user although it takes integer and string values. 
 * I just want to point out that it needs to get uppercase letters and that is a mistake.
 * In addition to these, we checked the limit of the maximum number of textboxes can receive. 
 * As a result, a successful restriction has been made.
 * */

//We declared arrays and variable 
def telNo=["5","4","4","6","2","5","6","2","4","9"]
def numbers=["1","2","3","4","5","6","7","8","9","0","1","2","3","4","5","6","7","8","9","0"]
def letters=["A","B","C","D","E","F","G"]
def lowerLetters=["a","b","c","d","e","f","g"]
String temp=""
//FWTA_GitFormx_001
//And we may check out with numbers
//We made the browser ready for testing.
WebUI.openBrowser('http://fizy.com/promocode/promo.html?locale=en')
WebUI.maximizeWindow()
WebUI.refresh()
WebUI.delay(5)

//FWTA_GitFormx_002
//Let's check out phone number textbox 
//Firstly we may check out with letters
for(int i=0;i<=6;i++){
	temp=temp+letters[i]
	WebUI.setText(findTestObject('giftForm/phoneNumber'), temp)
	WebUI.delay(2)	
}
//FWTA_GitFormx_003
//Then we may check out with lower letters
for(int i=0;i<=6;i++){
	temp=temp+lowerLetters[i]
	WebUI.setText(findTestObject('giftForm/phoneNumber'), temp)
	WebUI.delay(2)
}
//FWTA_GitFormx_004
//And we may check out with numbers
for(int i=0;i<=9;i++){
	temp=temp+telNo[i]
	WebUI.setText(findTestObject('giftForm/phoneNumber'), temp)
	WebUI.delay(2)
}
//FWTA_GitFormx_005
//We may check out length of tel no.It must be 10
for(int i=0;i<=20;i++){
	temp=temp+numbers[i]
	WebUI.setText(findTestObject('giftForm/phoneNumber'), temp)
	WebUI.delay(2)
}
//FWTA_GitFormx_006
//Let's check out giftSubcode textbox 
//Firstly we may check out with numbers 
temp=""
for(int i=0;i<=3;i++){
	temp=temp+numbers[i]
	WebUI.setText(findTestObject('giftForm/giftSubCode'), temp)
	WebUI.delay(2)
}
//FWTA_GitFormx_007
//Then we may check out with letters
temp=""
for(int i=0;i<=6;i++){
	temp=temp+letters[i]
	WebUI.setText(findTestObject('giftForm/giftSubCode'), temp)
	WebUI.delay(2)
}
//FWTA_GitFormx_008
//And we may check out with lower letters. 
//It's wrong part in the test case
temp=""
for(int i=0;i<=6;i++){
	temp=temp+lowerLetters[i]
	WebUI.setText(findTestObject('giftForm/giftSubCode'), temp)
	WebUI.delay(2)
}
//FWTA_GitFormx_009
temp=""
for(int i=0;i<=15;i++){
	temp=temp+numbers[i]
	WebUI.setText(findTestObject('giftForm/giftSubCode'), temp)
	WebUI.delay(2)
}

WebUI.closeBrowser()

