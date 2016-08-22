program BarcodeServer;

uses
  Forms,
  FrmMain in 'FrmMain.pas' {FormMain};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TFormMain, FormMain);
  Application.Run;
end.
