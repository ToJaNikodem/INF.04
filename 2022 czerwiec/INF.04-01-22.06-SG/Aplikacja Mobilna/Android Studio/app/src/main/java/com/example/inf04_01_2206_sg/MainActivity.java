package com.example.inf04_01_2206_sg;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    private TextView tvLikes;
    int likes = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        tvLikes = findViewById(R.id.likes);
    }

    private void refreshLikesCounter() {
        tvLikes.setText(likes + " polubień");
    }

    public void onClickBtnLike(View view) {
        likes++;
        refreshLikesCounter();
    }

    public void onClickBtnDelete(View view) {
        likes--;
        if(likes < 0) {
            likes = 0;
        }
        refreshLikesCounter();
    }
}