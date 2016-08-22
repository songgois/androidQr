object FormMain: TFormMain
  Left = 512
  Top = 292
  Width = 692
  Height = 544
  Caption = #26465#30721#25509#25910#26381#21153#22120
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  PixelsPerInch = 96
  TextHeight = 13
  object mmoReceive: TMemo
    Left = 0
    Top = 40
    Width = 676
    Height = 465
    Align = alBottom
    ScrollBars = ssVertical
    TabOrder = 0
  end
  object idtcpsrvr: TIdTCPServer
    Active = True
    Bindings = <>
    CommandHandlers = <>
    DefaultPort = 12345
    Greeting.NumericCode = 0
    MaxConnectionReply.NumericCode = 0
    OnExecute = idtcpsrvrExecute
    ReplyExceptionCode = 0
    ReplyTexts = <>
    ReplyUnknownCommand.NumericCode = 0
    Left = 632
    Top = 8
  end
end
