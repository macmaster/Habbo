/********************PLogGUI**********************************
 * Habbo Packet Logger GUI
 * Applet for Habbo packet logger
 * 
 * Author: Ronny Macmaster
 * Date: 3/27/16
 ***************************************************************/
package gui;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import jpcap.*;
import java.io.*;

public class PLogGUI{
	/** Globals */
	NetworkInterface[] NETWORK_INTERFACES;
	JpcapCaptor CAP;
	CaptureThread CAPTAIN;
	int INDEX = 0;
	int COUNTER = 0;
	boolean CaptureState = false;

	/** GUI Globals */
	JFrame mainWindow = new JFrame("Habbo Packet_Logger v1.0 - ©2016 Ronny Macmaster");
	JTextArea TA_OUTPUT = new JTextArea();
	JScrollPane SP_OUTPUT = new JScrollPane();
	ButtonGroup BG_Filters = new ButtonGroup();
	ButtonGroup BG_Ports = new ButtonGroup();
	JButton B_CAPTURE = new JButton("CAPTURE");
	JButton B_STOP = new JButton("STOP");
	JButton B_SELECT = new JButton("SELECT");
	JButton B_LIST = new JButton("LIST");
	JButton B_FILTER = new JButton("FILTER");
	JButton B_INFO = new JButton("INFO");
	JButton B_SAVE = new JButton("SAVE");
	JButton B_LOAD = new JButton("LOAD");
	JButton B_HELP = new JButton("HELP");
	JButton B_EXIT = new JButton("EXIT");
	JRadioButton RB_Filter_Enable = new JRadioButton("Enable");
	JRadioButton RB_Filter_Disable = new JRadioButton("Disable");
	JRadioButton RB_Port_Special = new JRadioButton("Special Port");
	JRadioButton RB_Port_HTTP = new JRadioButton("HTTP (80)");
	JRadioButton RB_Port_SSL = new JRadioButton("SSL (443)");
	JRadioButton RB_Port_FTP = new JRadioButton("FTP (21)");
	JRadioButton RB_Port_SSH = new JRadioButton("SSH (22)");
	JRadioButton RB_Port_TelNet = new JRadioButton("TelNet (23)");
	JRadioButton RB_Port_SMTP = new JRadioButton("SMTP (25)");
	JRadioButton RB_Port_POP3 = new JRadioButton("POP3 (110)");
	JRadioButton RB_Port_IMAP = new JRadioButton("IMAP (143)");
	JRadioButton RB_Port_IMAPS = new JRadioButton("IMAPS (993)");
	JRadioButton RB_Port_DNS = new JRadioButton("DNS (53)");
	JRadioButton RB_Port_NetBIOS = new JRadioButton("NetBIOS (139)");
	JRadioButton RB_Port_SAMBA = new JRadioButton("SAMBA (137)");
	JRadioButton RB_Port_AD = new JRadioButton("AD (445)");
	JRadioButton RB_Port_SQL = new JRadioButton("SQL (118)");
	JRadioButton RB_Port_LDAP = new JRadioButton("LDAP (389)");
	JLabel L_Title = new JLabel("Habbo Packet_Logger v1.0 - ©2016 Ronny Macmaster");
	JLabel L_Interface = new JLabel("Interface");
	JLabel L_FilterStatus = new JLabel("Port Filter Status");
	JLabel L_FilterStatusBox = new JLabel("DISABLED (ALL PORTS)");
	JLabel L_Presets = new JLabel("Port Filter Presets");
	JLabel L_SpecialPort = new JLabel("Special Port #");
	JTextField TF_SelectInterface = new JTextField();
	JTextField TF_SpecialPort = new JTextField();

	/** Entry point */
	public static void main(String[] args){
		PLogGUI userGUI = new PLogGUI();
	}

	/** GUI Constructor */
	public PLogGUI(){
		buildGUI();
		// disableButtons();
	}

	/**
	 * BuildGUI() initializes the PLogGUI settings
	 */
	public void buildGUI(){
		// calculate screen size
		Dimension screenSize = Toolkit.getDefaultToolkit().getScreenSize();
		int width = 800;
		int height = 600;
		int s_width = (int)screenSize.getWidth();
		int s_height = (int)screenSize.getHeight();

		// using absolute layout
		mainWindow.setSize(width, height);
		mainWindow.setLocation((s_width - width) / 2, (s_height - height) / 2);
		mainWindow.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		mainWindow.getContentPane().setLayout(null);

		// packet text area
		TA_OUTPUT.setEditable(false);
		TA_OUTPUT.setFont(new Font("Monospaced", 0, 12));
		TA_OUTPUT.setForeground(Color.blue);
		TA_OUTPUT.setLineWrap(true);

		// text scroll
		SP_OUTPUT.setHorizontalScrollBarPolicy(ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);
		SP_OUTPUT.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);
		SP_OUTPUT.setViewportView(TA_OUTPUT);
		SP_OUTPUT.setBounds((width / 60), (height / 24), (width * 19 / 20), (height * 9 / 16));
		mainWindow.getContentPane().add(SP_OUTPUT);

		// CAPTURE Button
		B_CAPTURE.setBackground(Color.RED);
		B_CAPTURE.setForeground(Color.white);
		B_CAPTURE.setBounds((width / 60), (height * 5 / 8), (width * 1 / 8), (height * 1 / 24));
		B_CAPTURE.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_CAPTURE(X);
			}
		});
		mainWindow.getContentPane().add(B_CAPTURE);

		// STOP Button
		B_STOP.setBackground(Color.black);
		B_STOP.setForeground(Color.white);
		B_STOP.setBounds((width * 10 / 60), (height * 5 / 8), (width * 1 / 8), (height * 1 / 24));
		B_STOP.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_STOP(X);
			}
		});
		mainWindow.getContentPane().add(B_STOP);

		// SELECT Button
		B_SELECT.setBackground(Color.black);
		B_SELECT.setForeground(Color.white);
		B_SELECT.setBounds((width / 60), (height * 13 / 16), (width * 1 / 8), (height * 1 / 24));
		B_SELECT.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_SELECT(X);
			}
		});
		mainWindow.getContentPane().add(B_SELECT);

		// LIST Button
		B_LIST.setBackground(Color.black);
		B_LIST.setForeground(Color.white);
		B_LIST.setBounds((width / 60), (height * 14 / 16), (width * 1 / 8), (height * 1 / 24));
		B_LIST.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_LIST(X);
			}
		});
		mainWindow.getContentPane().add(B_LIST);

		// FILTER Button
		B_CAPTURE.setBackground(Color.green);
		B_CAPTURE.setForeground(Color.white);
		B_CAPTURE.setBounds((width / 60), (height * 5 / 8), (width * 1 / 8), (height * 1 / 24));
		B_CAPTURE.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_CAPTURE(X);
			}
		});
		mainWindow.getContentPane().add(B_CAPTURE);

		// INFO Button
		B_INFO.setBackground(Color.black);
		B_INFO.setForeground(Color.white);
		B_INFO.setBounds((width * 10 / 60), (height * 12 / 16), (width * 1 / 8), (height * 1 / 24));
		B_INFO.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_INFO(X);
			}
		});
		mainWindow.getContentPane().add(B_INFO);

		// SAVE Button
		B_SAVE.setBackground(Color.black);
		B_SAVE.setForeground(Color.white);
		B_SAVE.setBounds((width * 10 / 60), (height * 11 / 16), (width * 1 / 8), (height * 1 / 24));
		B_SAVE.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_SAVE(X);
			}
		});
		mainWindow.getContentPane().add(B_SAVE);

		// LOAD Button
		B_LOAD.setBackground(Color.black);
		B_LOAD.setForeground(Color.white);
		B_LOAD.setBounds((width * 18 / 60), (height * 11 / 16), (width * 1 / 8), (height * 1 / 24));
		B_LOAD.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_LOAD(X);
			}
		});
		mainWindow.getContentPane().add(B_LOAD);

		// HELP Button
		B_HELP.setBackground(Color.black);
		B_HELP.setForeground(Color.white);
		B_HELP.setBounds((width * 18 / 60), (height * 12 / 16), (width * 1 / 8), (height * 1 / 24));
		B_HELP.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_HELP(X);
			}
		});
		mainWindow.getContentPane().add(B_HELP);

		// EXIT Button
		B_EXIT.setBackground(Color.red);
		B_EXIT.setForeground(Color.white);
		B_EXIT.setBounds((width * 18 / 60), (height * 5 / 8), (width * 1 / 8), (height * 1 / 24));
		B_EXIT.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent X){
				Action_B_EXIT(X);
			}
		});
		mainWindow.getContentPane().add(B_EXIT);

		mainWindow.setVisible(true);
	}

	/** Event Handlers */
	public void Action_B_CAPTURE(ActionEvent X){
		TA_OUTPUT.append("capture!\n");
	}
	
	public void Action_B_STOP(ActionEvent X){
		TA_OUTPUT.append("stop!\n");
	}
	
	public void Action_B_SELECT(ActionEvent X){
		TA_OUTPUT.append("select!\n");
	}
	
	public void Action_B_LIST(ActionEvent X){
		TA_OUTPUT.append("list!\n");
	}
	
	public void Action_B_FILTER(ActionEvent X){
		TA_OUTPUT.append("filter!\n");
	}
	
	public void Action_B_INFO(ActionEvent X){
		TA_OUTPUT.append("info!\n");
	}
	
	public void Action_B_SAVE(ActionEvent X){
		TA_OUTPUT.append("save!\n");
	}
	
	public void Action_B_LOAD(ActionEvent X){
		TA_OUTPUT.append("load!\n");
	}
	
	public void Action_B_HELP(ActionEvent X){
		TA_OUTPUT.append("help!\n");
	}
	
	public void Action_B_EXIT(ActionEvent X){
		TA_OUTPUT.append("exit!\n");
	}
}
