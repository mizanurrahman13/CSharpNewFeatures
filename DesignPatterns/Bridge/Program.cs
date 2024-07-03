using Bridge;

ILanguage english = new English();
ILanguage spanish = new Spanish();
ILanguage french = new French();

Subject mathBookInEnglist = new Bridge.Math(english);
mathBookInEnglist.DisplayContent();

Subject historyBookInSpanish = new History(spanish);
historyBookInSpanish.DisplayContent();

Subject mathBookInFrench = new Bridge.Math(french);
mathBookInFrench.DisplayContent();
