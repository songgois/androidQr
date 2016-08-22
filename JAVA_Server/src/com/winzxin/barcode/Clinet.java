package com.winzxin.barcode;

import java.io.IOException;
import java.io.OutputStream;
import java.net.Socket;
import java.net.UnknownHostException;

public class Clinet {

	//测试方法
	
	public static void main(String[] args) throws UnknownHostException, IOException, InterruptedException {
		if(args[0] == null)
			throw new UnknownHostException();
		Socket socket = new Socket(args[0], 12345);
		OutputStream o = socket.getOutputStream();
		for (int i = 0; i < 100; i++) {
			o.write(( "barcode is 中文\r\n").getBytes());
			Thread.sleep(10);
		}
		o.flush();
		o.close();
		socket.close();
	}
	
}
