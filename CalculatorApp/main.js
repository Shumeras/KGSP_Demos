const { app, BrowserWindow } = require("electron");

let win;

function creatWindow()
{
    win = new BrowserWindow(
        {
            width:300,
            height: 430,
            backgroundColor: '#ffffff',
            autoHideMenuBar: true,
            resizable: false
        }
    )
    
    win.loadURL(`file://${__dirname}/dist/index.html`)

    //win.webContents.openDevTools()

    win.on('closed', () => {win = null})
}

app.on('ready', creatWindow)

app.on('window-all-closed', 
    () =>
    {
        if(process.platform !== 'darwin')
            app.quit();
    }
)

app.on('activate', 
    () =>
    {
        if(win === null)
            createWindow()
    }
)