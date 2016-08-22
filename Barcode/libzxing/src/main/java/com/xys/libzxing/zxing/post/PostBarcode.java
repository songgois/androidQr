package com.xys.libzxing.zxing.post;

import android.text.TextUtils;

import java.io.IOException;
import java.io.OutputStream;
import java.net.InetSocketAddress;
import java.net.Socket;

/**
 * Created by song on 2016/8/22.
 */
public class PostBarcode implements Runnable {
    private String host;
    private String bar;

    public PostBarcode(String host,String bar) throws Exception {
        if (TextUtils.isEmpty(host)){
            throw  new Exception("host is empty");
        }
        if (TextUtils.isEmpty(bar)){
            throw  new Exception("bar is empty");
        }
        this.host = host;
        this.bar = bar;
    }
    @Override
    public void run() {
        Socket socket = new Socket();
        InetSocketAddress ip =  new InetSocketAddress(host,12345);
        try {
            socket.connect(ip,1000);
            OutputStream outputStream = socket.getOutputStream();
            outputStream.write(bar.getBytes());
            outputStream.flush();
            outputStream.close();
            socket.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
