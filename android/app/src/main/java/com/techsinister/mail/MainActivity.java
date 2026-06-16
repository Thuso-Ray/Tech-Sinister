package com.techsinister.mail;
import android.os.Bundle; import android.webkit.WebView; import android.webkit.WebViewClient; import androidx.appcompat.app.AppCompatActivity;
public class MainActivity extends AppCompatActivity {
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        WebView wv = findViewById(R.id.webview);
        wv.setWebViewClient(new WebViewClient());
        wv.getSettings().setJavaScriptEnabled(true);
        wv.loadUrl("https://techsinister.com");
    }
}