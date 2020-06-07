package com.bnuz.oke.api;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.stereotype.Component;

import javax.websocket.OnClose;
import javax.websocket.OnError;
import javax.websocket.OnOpen;
import javax.websocket.Session;
import javax.websocket.server.PathParam;
import javax.websocket.server.ServerEndpoint;
import java.io.IOException;
import java.util.concurrent.ConcurrentHashMap;

/**
 * WebSocketServer
 *
 * @author handsome
 * @date 2020年 05月26日 14:50:46
 */
@ServerEndpoint("/imserver/{studentId}")
@Component
public class WebSocketServer {
	static Logger logger = LoggerFactory.getLogger(WebSocketServer.class);
	private static ConcurrentHashMap<String,WebSocketServer> webSocketMap = new ConcurrentHashMap<>();
	private Session session;
	private String studentId = "";

	/**
	 * 连接建立成功调用的方法 
	 * @date 2020/05/26 14:58:17
	 * @author handsome
	 * @param session
	 * @param studentId
	 * @return void
	 */        
	@OnOpen
	public void onOpen(Session session,@PathParam("studentId") String studentId) {
		this.session = session;
		this.studentId = studentId;
		if(webSocketMap.containsKey(studentId)){
			webSocketMap.remove(studentId);
			webSocketMap.put(studentId, this);
		}else{
			webSocketMap.put(studentId, this);
		}
		logger.info("学生连接:" + studentId);
	}

	/**
	 * 连接关闭调用的方法 
	 * @date 2020/05/26 14:58:32
	 * @author handsome
	 * @param 
	 * @return void
	 */        
	@OnClose
	public void onClose() {
		if(webSocketMap.containsKey(studentId)){
			webSocketMap.remove(studentId);
		}
		logger.info("学生退出:" + studentId);
	}

	/**
	 * 连接错误调用的方法
	 * @date 2020/05/26 15:01:56
	 * @author handsome
	 * @param session
 	 * @param error
	 * @return void
	 */        
	@OnError
	public void onError(Session session, Throwable error) {
		logger.error("学生错误:" + this.studentId + ", 原因:"+error.getMessage());
		error.printStackTrace();
	}

	/**
	 * 实现服务器主动推送
	 * @date 2020/05/26 15:02:31
	 * @author handsome
	 * @param message
	 * @return void
	 */        
	public void sendMessage(String message) throws IOException {
		this.session.getBasicRemote().sendText(message);
	}

	/**
	 * 发送自定义消息
	 * @date 2020/05/26 15:05:00
	 * @author handsome
	 * @param message
 	 * @param studentId
	 * @return void
	 */
	public static void sendInfo(String message, @PathParam("studentId") String studentId) throws IOException {
		if(webSocketMap.containsKey(studentId)){
			webSocketMap.get(studentId).sendMessage(message);
		}else{
			logger.error("学生" + studentId + ",不在线！");
		}
	}
}
