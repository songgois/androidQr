package com.winzxin.barcode;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.concurrent.ConcurrentLinkedQueue;

//��ʾ��ʵ����ʹ�� ServerSocketChannel ��NIO��

public class Server implements Runnable {
	
	private static int port = 12345;
	private static ServerSocket server; 
	private static ConcurrentLinkedQueue<String> barQueue = new ConcurrentLinkedQueue<>();
	
	public static void main(String[] args) throws IOException {
		server = new ServerSocket(port);
		System.out.println("������������");
		new Thread(new Server()).start();		
	}

	@Override
	public void run() {
		while(true){
			try {
				Socket socket = server.accept();
				InputStream in = socket.getInputStream();
				InputStreamReader reader = new InputStreamReader(in,"utf-8");
				BufferedReader bufferedReader = new BufferedReader(reader);				
/*				int i; //���ַ���ȡ
				while((i=bufferedReader.read())!=-1){
					System.out.print(""+(char)i);
				}*/
								
				String bar;
				while ((bar=bufferedReader.readLine())!=null) {
					//ʵ�ʵ�ҵ�����߼�	֧�ֶ�������һ��socket���н��ղ����� ÿ�������� \r\n����
					BarcodeHandler handler = new BarcodeHandlerImpl();					
					barQueue.add(handler.post(bar));					
				}	
				in.close();
				socket.close();
				/*
				for (String string : barQueue) {
					System.out.println(string);
				}			
				*/	
			} catch (IOException e) {
				e.printStackTrace();
			}
			
		}
	}
}
